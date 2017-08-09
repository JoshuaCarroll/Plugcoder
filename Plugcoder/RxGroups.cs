using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    class RxGroups : MD380RDTObjectGroup
    {
        public List<RxGroup> List;

        public RxGroups(byte[] bytes)
        {
            List = new List<RxGroup>();

            for (int i = this.FirstByte; i < this.LastByte; i += this.BytesPerEntry)
            {
                RxGroup rxGroup = new RxGroup(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if ((rxGroup.Name != "") && (rxGroup.Name != null))
                {
                    List.Add(rxGroup);
                }
            }
        }
    }
}
