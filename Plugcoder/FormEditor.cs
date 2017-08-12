using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugcoder
{
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            LoadRdtFile(openFileDialog1.FileName);
        }

        private void LoadRdtFile(string filename)
        {
            Plugcoder.Codeplug codeplug = new Plugcoder.Codeplug(filename);

            for (int i = 0; i < codeplug.Zones.List.Count; i++)
            {
                TreeNode zoneNode = treeViewChannels.Nodes.Add(codeplug.Zones.List[i].Name);

                for (int j = 0; j < codeplug.Zones.List[i].ChannelIndexList.Count; j++)
                {
                    int channelIndex = codeplug.Zones.List[i].ChannelIndexList[j];
                    Channel channel = codeplug.Channels.Items[channelIndex];
                    TreeNode channelNode = zoneNode.Nodes.Add(channelIndex.ToString(), channel.Name);
                }
            }
        }
    }
}
