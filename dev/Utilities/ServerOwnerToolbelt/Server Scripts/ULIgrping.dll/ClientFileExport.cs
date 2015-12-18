/* Copyright (C) 2013 Ian Karlinsey
 * 
 * UltimeLive is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * UltimaLive is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with UltimaLive.  If not, see <http://www.gnu.org/licenses/>. 
 */

using System;
using System.Net;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Commands;
using Server.Commands.Generic;

namespace UltimaLive
{
  public class ClientFileExport
  {
    public static void Initialize()
    {
      CommandSystem.Prefix = "[";
      Register("ExportClientFiles", AccessLevel.GameMaster, new CommandEventHandler(exportClientFiles_OnCommand));
      Register("PrintLandData", AccessLevel.GameMaster, new CommandEventHandler(printLandData_OnCommand));
      Register("PrintStaticsData", AccessLevel.GameMaster, new CommandEventHandler(printStaticsData_OnCommand));
      Register("PrintCrc", AccessLevel.GameMaster, new CommandEventHandler(printCrc_OnCommand));
    }

    [Usage("PrintCrc")]
    [Description("Increases the Z value of a static.")]
    private static void printCrc_OnCommand(CommandEventArgs e)
    {
      Mobile from = e.Mobile;
      Map playerMap = from.Map;
      TileMatrix tm = playerMap.Tiles;

      int blocknum = (((from.Location.X >> 3) * tm.BlockHeight) + (from.Location.Y >> 3));
      byte[] LandData = BlockUtility.GetLandData(blocknum, playerMap.MapID);
      byte[] StaticsData = BlockUtility.GetRawStaticsData(blocknum, playerMap.MapID);

      byte[] blockData = new byte[LandData.Length + StaticsData.Length];
      Array.Copy(LandData, blockData, LandData.Length);
      Array.Copy(StaticsData, 0, blockData, LandData.Length, StaticsData.Length);


      UInt16 crc = CRC.Fletcher16(blockData);
      Console.WriteLine("CRC is 0x" + crc.ToString("X4"));
    }

    [Usage("PrintLandData")]
    [Description("Increases the Z value of a static.")]
    private static void printLandData_OnCommand(CommandEventArgs e)
    {
      Mobile from = e.Mobile;
      Map playerMap = from.Map;
      TileMatrix tm = playerMap.Tiles;

      int blocknum = (((from.Location.X >> 3) * tm.BlockHeight) + (from.Location.Y >> 3));
      byte[] data = BlockUtility.GetLandData(blocknum, playerMap.MapID);
      BlockUtility.WriteLandDataToConsole(data);
    }

    [Usage("PrintStaticsData")]
    [Description("Increases the Z value of a static.")]
    private static void printStaticsData_OnCommand(CommandEventArgs e)
    {
      Mobile from = e.Mobile;
      Map playerMap = from.Map;
      TileMatrix tm = playerMap.Tiles;

      int blocknum = (((from.Location.X >> 3) * tm.BlockHeight) + (from.Location.Y >> 3));
      byte[] data = BlockUtility.GetRawStaticsData(blocknum, playerMap.MapID);
      BlockUtility.WriteDataToConsole(data);

    }


    [Usage("ExportClientFiles")]
    [Description("Increases the Z value of a static.")]
    private static void exportClientFiles_OnCommand(CommandEventArgs e)
    {
      ExportOnNextSave = true;
      Server.Misc.AutoSave.Save();
    }

    public static void Register(string command, AccessLevel access, CommandEventHandler handler)
    {
      CommandSystem.Register(command, access, handler);
    }

    public static void Configure()
    {
      EventSink.WorldSave += new WorldSaveEventHandler(OnSave);
    }

    public static bool ExportOnNextSave = false;

    private static Map m_WorkMap = null;
    public static Map WorkMap { get { return m_WorkMap; } }
    public static void OnSave(WorldSaveEventArgs e)
    {
      if (!ExportOnNextSave)
      {
        return;
      }

      ExportOnNextSave = false;

      if (!Directory.Exists(UltimaLiveSettings.UltimaLiveClientExportPath))
          Directory.CreateDirectory(UltimaLiveSettings.UltimaLiveClientExportPath);

      Console.Write("Exporting Client Files...");

      /* maps */
      // public static Dictionary<int, MapDefinition> Definitions
      foreach (KeyValuePair<int, MapRegistry.MapDefinition> kvp in MapRegistry.Definitions)
      {
        if (!MapRegistry.MapAssociations.ContainsKey(kvp.Key))
        {
          continue;
        }
          
        string filename = string.Format("map{0}.mul", kvp.Key);
        GenericWriter writer = new BinaryFileWriter(Path.Combine(UltimaLiveSettings.UltimaLiveClientExportPath, filename), true);
        m_WorkMap = Server.Map.Maps[kvp.Key];
        TileMatrix CurrentMatrix = m_WorkMap.Tiles;
        int blocks = CurrentMatrix.BlockWidth * CurrentMatrix.BlockHeight;
        for (int xblock = 0; xblock < CurrentMatrix.BlockWidth; xblock++)
          for (int yblock = 0; yblock < CurrentMatrix.BlockHeight; yblock++)
          {
            writer.Write((uint)0);
            LandTile[] blocktiles = CurrentMatrix.GetLandBlock(xblock, yblock);
            if (blocktiles.Length == 196)
            {
              Console.WriteLine("Invalid landblock! Save failed!");
              return;
            }
            else
            {
              for (int j = 0; j < 64; j++)
              {
                writer.Write((short)blocktiles[j].ID);
                writer.Write((sbyte)blocktiles[j].Z);
              }
            }
          }
        writer.Close();
      }

      /* Statics */
      foreach (KeyValuePair<int, MapRegistry.MapDefinition> kvp in MapRegistry.Definitions)
      {
        if (!MapRegistry.MapAssociations.ContainsKey(kvp.Key))
        {
          continue;
        }

        string filename = string.Format("statics{0}.mul", kvp.Key);
        GenericWriter staticWriter = new BinaryFileWriter(Path.Combine(UltimaLiveSettings.UltimaLiveClientExportPath, filename), true);
        filename = string.Format("staidx{0}.mul", kvp.Key);
        GenericWriter staticIndexWriter = new BinaryFileWriter(Path.Combine(UltimaLiveSettings.UltimaLiveClientExportPath, filename), true);

				m_WorkMap = Server.Map.Maps[kvp.Key];
				TileMatrix CurrentMatrix = m_WorkMap.Tiles;

        int blocks = CurrentMatrix.BlockWidth * CurrentMatrix.BlockHeight;

        int startBlock = 0;
        int finishBlock = 0;

        for (int xblock = 0; xblock < CurrentMatrix.BlockWidth; xblock++)
        {
          for (int yblock = 0; yblock < CurrentMatrix.BlockHeight; yblock++)
          {
            StaticTile[][][] staticTiles = CurrentMatrix.GetStaticBlock(xblock, yblock);

            //Static File
            for (int i = 0; i < staticTiles.Length; i++)
              for (int j = 0; j < staticTiles[i].Length; j++)
              {
                StaticTile[] sortedTiles = staticTiles[i][j];
                Array.Sort(sortedTiles, BlockUtility.CompareStaticTiles);

                for (int k = 0; k < sortedTiles.Length; k++)
                {
                  staticWriter.Write((ushort)sortedTiles[k].ID);
                  staticWriter.Write((byte)i);
                  staticWriter.Write((byte)j);
                  staticWriter.Write((sbyte)sortedTiles[k].Z);
                  staticWriter.Write((short)sortedTiles[k].Hue);
                  finishBlock += 7;
                }
              }

            //Index File
            if (finishBlock != startBlock)
            {
              staticIndexWriter.Write((int)startBlock); //lookup
              staticIndexWriter.Write((int)(finishBlock - startBlock)); //length
              staticIndexWriter.Write((int)0); //extra
              startBlock = finishBlock;
            }
            else
            {
              staticIndexWriter.Write((uint)uint.MaxValue); //lookup
              staticIndexWriter.Write((uint)uint.MaxValue); //length
              staticIndexWriter.Write((uint)uint.MaxValue); //extra
            }
          }
        }
        staticWriter.Close();
        staticIndexWriter.Close();
      }
    }
  }
}