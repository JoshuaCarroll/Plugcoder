using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    public class Channels : MD380RDTObjectGroup
    {
        public Dictionary<int, Channel> Items;

        public Channels(byte[] bytes)
        {
            Items = new Dictionary<int, Channel>();

            for (int i = this.FirstByte; i < this.LastByte; i+= this.BytesPerEntry)
            {
                Channel channel = new Channel(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if ((channel.Name != "") && (channel.Name != null))
                {
                    int index = ((i - this.FirstByte) / this.BytesPerEntry) + 1;
                    Items.Add(index, channel);
                }
            }
        }
    }
}
