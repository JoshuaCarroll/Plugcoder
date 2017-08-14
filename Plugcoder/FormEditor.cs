using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Codeplug codeplug = new Codeplug(filename);
            TreeNode codeplugNode = treeViewCodeplugs.Nodes.Add("Codeplug (" + filename + ")");

            for (int i = 0; i < codeplug.Zones.List.Count; i++)
            {
                TreeNode zoneNode = codeplugNode.Nodes.Add(codeplug.Zones.List[i].Name);
                zoneNode.ContextMenuStrip = contextZone;
                zoneNode.Tag = codeplug.Zones.List[i];

                for (int j = 0; j < codeplug.Zones.List[i].ChannelIndexList.Count; j++)
                {
                    int channelIndex = codeplug.Zones.List[i].ChannelIndexList[j];
                    Channel channel = codeplug.Channels.Items[channelIndex];
                    TreeNode channelNode = zoneNode.Nodes.Add(channelIndex.ToString(), channel.Name);
                    channelNode.ContextMenuStrip = contextChannel;
                    channelNode.Tag = channel;
                }
            }

            treeViewCodeplugs.ExpandAll();
        }

        private void OpenDebugFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDebug().Show();
        }

        private void treeViewCodeplugs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeTypeString = (e.Node.Tag != null) ? e.Node.Tag.GetType().Name : string.Empty;

            switch (nodeTypeString)
            {
                case "Channel":
                    groupBoxChannel.Visible = true;
                    Channel channel = (Channel)e.Node.Tag;
                    txtChannelFrequency.Text = channel.ReceiveFrequency.ToString();
                    txtChannelName.Text = channel.Name;
                    txtChannelReceiveGroup.Text = channel.ReceiveGroupIndex.ToString();
                    txtChannelRekeyDelay.Text = channel.TimeOutTimeRekeyDelay.ToString();
                    txtChannelScanList.Text = channel.ScanListIndex.ToString();
                    txtChannelTalkgroup.Text = channel.ContactIndex.ToString();
                    txtChannelTimeout.Text = channel.TimeOutTime.ToString();
                    txtChannelTransmitOffset.Text = (channel.TransmitFrequency - channel.ReceiveFrequency).ToString();
                    break;
                default:
                    groupBoxChannel.Visible = false;
                    break;
            }
        }

        private void submitBugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoshuaCarroll/Plugcoder/issues/new");
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JoshuaCarroll/Plugcoder/wiki/User-guide");
        }
    }
}
