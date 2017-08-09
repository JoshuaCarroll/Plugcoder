using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugcoder
{
    public class Channels : MD380RDTObjectGroup
    {
        public List<Channel> List;

        public Channels(byte[] bytes)
        {
            List = new List<Channel>();

            for (int i = this.FirstByte; i < this.LastByte; i+= this.BytesPerEntry)
            {
                Channel channel = new Channel(new ArraySegment<byte>(bytes, i, this.BytesPerEntry));

                if ((channel.Name != "") && (channel.Name != null))
                {
                    List.Add(channel);
                }
            }
        }
    }
}
