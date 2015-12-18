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
using System.Collections.Generic;
using System.Text;
using Server;

namespace UltimaLive
{
    public class CRC
    {
        //CRC caching
        //[map][block]
        public static UInt16[][] MapCRCs; 

        public static void InvalidateBlockCRC(int map, int block)
        {
            MapCRCs[map][block] = UInt16.MaxValue;
        }

        public static void Configure()
        {
            EventSink.WorldLoad += new WorldLoadEventHandler(OnLoad);
        }

        public static void OnLoad()
        {
            MapCRCs = new UInt16[256][];

            //We need CRCs for every block in every map.  
            foreach (KeyValuePair<int, MapRegistry.MapDefinition> kvp in MapRegistry.Definitions)
            {
                int blocks = Server.Map.Maps[kvp.Key].Tiles.BlockWidth * Server.Map.Maps[kvp.Key].Tiles.BlockHeight;
                MapCRCs[kvp.Key] = new UInt16[blocks];

                for (int j = 0; j < blocks; j++)
                {
                    MapCRCs[kvp.Key][j] = UInt16.MaxValue;
                }

            }
        }

        /* Thank you http://en.wikipedia.org/wiki/Fletcher%27s_checksum
         * Each sum is computed modulo 255 and thus remains less than 
         * 0xFF at all times. This implementation will thus never 
         * produce the checksum results 0x00FF, 0xFF00 or 0xFFFF.
        /**/
        public static UInt16 Fletcher16( byte[] data)
        {
           UInt16 sum1 = 0;
           UInt16 sum2 = 0;
           int index;
           for( index = 0; index < data.Length; ++index )
           {
              sum1 = (UInt16) ((sum1 + data[index]) % 255);
              sum2 = (UInt16) ((sum2 + sum1) % 255);
           }

           return (UInt16)((sum2 << 8) | sum1);
        }
    }
}
