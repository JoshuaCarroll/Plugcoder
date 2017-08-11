using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Zone: MD380RDTObjectGroup
    {
        public string Name;
        public List<int> ContactIndexList;

        public Zone(ArraySegment<byte> bytes)
        {
            if (bytes.Count == this.BytesPerEntry)
            {
                Name = "";
                for (int i = bytes.Offset + 0; i < bytes.Offset + 32; i+=2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X2") + bytes.Array[i].ToString("X2");

                    if (hexValue != "0000")
                    {
                        Name += hexValue.hexToAscii();
                    }
                    else
                    {
                        break;
                    }   
                }

                ContactIndexList = new List<int>();
                for (int i = bytes.Offset + 32; i < bytes.Offset + this.BytesPerEntry; i += 2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X2") + bytes.Array[i].ToString("X2");

                    if (hexValue != "0000")
                    {
                        ContactIndexList.Add(hexValue.hexToDec());
                    }
                }
            }
            else
            {
                throw new FormatException("Invalid data creating receive group");
            }
        }
    }
}
