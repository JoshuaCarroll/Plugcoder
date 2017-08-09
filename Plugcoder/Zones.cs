using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class Zones : MD380RDTObjectGroup
    {
        public List<Zone> List;

        public Zones(byte[] bytes)
        {
            List = new List<Zone>();

            for (int i = this.FirstByte; i < this.LastByte; i += this.BytesPerEntry)
            {
                Zone zone = new Zone(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if ((zone.Name != "") && (zone.Name != null))
                {
                    List.Add(zone);
                }
            }
        }
    }
}
