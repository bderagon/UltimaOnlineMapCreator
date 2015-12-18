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
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Network;
using Server.Targeting;
using Server.Mobiles;

namespace UltimaLive
{
  public class MapRegistry
  {
    public struct MapDefinition
    {
      public int FileIndex;
      public Point2D Dimensions;
      public Point2D WrapAroundDimensions;
      public MapDefinition(int index, Point2D dimension, Point2D wraparound)
      {
        FileIndex = index;
        Dimensions = dimension;
        WrapAroundDimensions = wraparound;
      }
    }

    private static Dictionary<int, MapDefinition> m_Definitions = new Dictionary<int, MapDefinition>();
    public static Dictionary<int, MapDefinition> Definitions
    {
      get { return m_Definitions; }
    }
    private static Dictionary<int, List<int>> m_MapAssociations = new Dictionary<int, List<int>>();
    public static Dictionary<int, List<int>> MapAssociations
    {
      get { return m_MapAssociations; }
    }


    public static void AddMapDefinition(int index, int associated, Point2D dimensions, Point2D wrapDimensions)
    {
      if (!m_Definitions.ContainsKey(index))
      {
        m_Definitions.Add(index, new MapDefinition(associated, dimensions, wrapDimensions));
        if (m_MapAssociations.ContainsKey(associated))
        {
          m_MapAssociations[associated].Add(index);
        }
        else
        {
          m_MapAssociations[associated] = new List<int>();
          m_MapAssociations[associated].Add(index);
        }
      }
    }

    public static void Configure()
    {
      AddMapDefinition(0, 0, new Point2D(7168, 4096), new Point2D(5120, 4096)); //felucca
      AddMapDefinition(1, 1, new Point2D(7168, 4096), new Point2D(5120, 4096)); //trammel
      AddMapDefinition(2, 2, new Point2D(2304, 1600), new Point2D(2304, 1600)); //Ilshenar
      AddMapDefinition(3, 3, new Point2D(2560, 2048), new Point2D(2560, 2048)); //Malas
      AddMapDefinition(4, 4, new Point2D(1448, 1448), new Point2D(1448, 1448)); //Tokuno
      AddMapDefinition(5, 5, new Point2D(1280, 4096), new Point2D(1280, 4096)); //TerMur

      #region UOAvocation - Ultima Live System [01-01]

      #region Map Addition Format
      /*
        1st Point2D Location = Map Dimensions | 2nd Point2D Location = Wrap Points
       
        AddMapDefinition(32, 32, new Point2D(7168, 4096), new Point2D(5120, 4096));
        AddMapDefinition(33, 33, new Point2D(7168, 4096), new Point2D(5120, 4096));
      */
      #endregion

      AddMapDefinition(34, 34, new Point2D(7168, 4096), new Point2D(5120, 4096));

      #endregion Edited By: A.A.S.R

      EventSink.ServerList += new ServerListEventHandler(EventSink_OnServerList);
      EventSink.Login += new LoginEventHandler(EventSink_Login);
    }

    private static void EventSink_OnServerList(ServerListEventArgs args)
    {
      args.State.Send(new UltimaLive.Network.LoginComplete());
      args.State.Send(new UltimaLive.Network.MapDefinitions());
    }

    private static void EventSink_Login(LoginEventArgs args)
    {
      args.Mobile.Send(new UltimaLive.Network.QueryClientHash(args.Mobile));
    }
  }
}