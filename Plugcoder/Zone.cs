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
        public List<int> ContactIndex;

        public Zone(ArraySegment<byte> bytes)
        {
            if (bytes.Count == this.BytesPerEntry)
            {
                Name = "";
                for (int i = bytes.Offset + 0; i < bytes.Offset + 32; i+=2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X") + bytes.Array[i].ToString("X");

                    if (hexValue != "00")
                    {
                        Name += hexValue.hexToAscii();
                    }
                    else
                    {
                        break;
                    }   
                }

                ContactIndex = new List<int>();
                for (int i = bytes.Offset + 32; i < bytes.Offset + 32; i += 2)
                {
                    string hexValue = bytes.Array[i + 1].ToString("X") + bytes.Array[i].ToString("X");

                    if (hexValue != "00")
                    {
                        ContactIndex.Add(hexValue.hexToDec());
                    }
                    else
                    {
                        break;
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
