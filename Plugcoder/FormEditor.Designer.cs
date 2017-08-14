namespace Plugcoder
{
    partial class FormEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewCodeplugs = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDebugFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextChannel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.channelToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.channelToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextZone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoneToolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxChannel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChannelFrequency = new System.Windows.Forms.TextBox();
            this.txtChannelTransmitOffset = new System.Windows.Forms.TextBox();
            this.txtChannelTalkgroup = new System.Windows.Forms.TextBox();
            this.txtChannelTimeout = new System.Windows.Forms.TextBox();
            this.txtChannelRekeyDelay = new System.Windows.Forms.TextBox();
            this.txtChannelScanList = new System.Windows.Forms.TextBox();
            this.txtChannelReceiveGroup = new System.Windows.Forms.TextBox();
            this.submitBugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextChannel.SuspendLayout();
            this.contextZone.SuspendLayout();
            this.groupBoxChannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCodeplugs
            // 
            this.treeViewCodeplugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewCodeplugs.Location = new System.Drawing.Point(12, 27);
            this.treeViewCodeplugs.Name = "treeViewCodeplugs";
            this.treeViewCodeplugs.Size = new System.Drawing.Size(400, 472);
            this.treeViewCodeplugs.TabIndex = 0;
            this.treeViewCodeplugs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCodeplugs_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.submitBugReportToolStripMenuItem,
            this.toolStripSeparator2,
            this.openDebugFormToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openDebugFormToolStripMenuItem
            // 
            this.openDebugFormToolStripMenuItem.Name = "openDebugFormToolStripMenuItem";
            this.openDebugFormToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openDebugFormToolStripMenuItem.Text = "Open debug form";
            this.openDebugFormToolStripMenuItem.Click += new System.EventHandler(this.OpenDebugFormToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Codeplug files|*.rdt";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // contextChannel
            // 
            this.contextChannel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelToolStripMenuItemCopy,
            this.channelToolStripMenuItemDelete});
            this.contextChannel.Name = "contextChannel";
            this.contextChannel.Size = new System.Drawing.Size(108, 48);
            // 
            // channelToolStripMenuItemCopy
            // 
            this.channelToolStripMenuItemCopy.Name = "channelToolStripMenuItemCopy";
            this.channelToolStripMenuItemCopy.Size = new System.Drawing.Size(107, 22);
            this.channelToolStripMenuItemCopy.Text = "Copy";
            // 
            // channelToolStripMenuItemDelete
            // 
            this.channelToolStripMenuItemDelete.Name = "channelToolStripMenuItemDelete";
            this.channelToolStripMenuItemDelete.Size = new System.Drawing.Size(107, 22);
            this.channelToolStripMenuItemDelete.Text = "Delete";
            // 
            // contextZone
            // 
            this.contextZone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItemCreate,
            this.zoneToolStripMenuItemAdd,
            this.toolStripSeparator1,
            this.zoneToolStripMenuItemRename,
            this.zoneToolStripMenuItemDelete});
            this.contextZone.Name = "contextChannel";
            this.contextZone.Size = new System.Drawing.Size(185, 98);
            // 
            // zoneToolStripMenuItemCreate
            // 
            this.zoneToolStripMenuItemCreate.Name = "zoneToolStripMenuItemCreate";
            this.zoneToolStripMenuItemCreate.Size = new System.Drawing.Size(184, 22);
            this.zoneToolStripMenuItemCreate.Text = "Create new channel";
            // 
            // zoneToolStripMenuItemAdd
            // 
            this.zoneToolStripMenuItemAdd.Name = "zoneToolStripMenuItemAdd";
            this.zoneToolStripMenuItemAdd.Size = new System.Drawing.Size(184, 22);
            this.zoneToolStripMenuItemAdd.Text = "Add existing channel";
            // 
            // zoneToolStripMenuItemDelete
            // 
            this.zoneToolStripMenuItemDelete.Name = "zoneToolStripMenuItemDelete";
            this.zoneToolStripMenuItemDelete.Size = new System.Drawing.Size(184, 22);
            this.zoneToolStripMenuItemDelete.Text = "Delete";
            // 
            // zoneToolStripMenuItemRename
            // 
            this.zoneToolStripMenuItemRename.Name = "zoneToolStripMenuItemRename";
            this.zoneToolStripMenuItemRename.Size = new System.Drawing.Size(184, 22);
            this.zoneToolStripMenuItemRename.Text = "Rename";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // groupBoxChannel
            // 
            this.groupBoxChannel.Controls.Add(this.txtChannelReceiveGroup);
            this.groupBoxChannel.Controls.Add(this.txtChannelScanList);
            this.groupBoxChannel.Controls.Add(this.txtChannelRekeyDelay);
            this.groupBoxChannel.Controls.Add(this.txtChannelTimeout);
            this.groupBoxChannel.Controls.Add(this.txtChannelTalkgroup);
            this.groupBoxChannel.Controls.Add(this.txtChannelTransmitOffset);
            this.groupBoxChannel.Controls.Add(this.txtChannelFrequency);
            this.groupBoxChannel.Controls.Add(this.label8);
            this.groupBoxChannel.Controls.Add(this.label7);
            this.groupBoxChannel.Controls.Add(this.label6);
            this.groupBoxChannel.Controls.Add(this.label5);
            this.groupBoxChannel.Controls.Add(this.label4);
            this.groupBoxChannel.Controls.Add(this.label3);
            this.groupBoxChannel.Controls.Add(this.label2);
            this.groupBoxChannel.Controls.Add(this.txtChannelName);
            this.groupBoxChannel.Controls.Add(this.label1);
            this.groupBoxChannel.Location = new System.Drawing.Point(433, 27);
            this.groupBoxChannel.Name = "groupBoxChannel";
            this.groupBoxChannel.Size = new System.Drawing.Size(421, 472);
            this.groupBoxChannel.TabIndex = 3;
            this.groupBoxChannel.TabStop = false;
            this.groupBoxChannel.Text = "Channel";
            this.groupBoxChannel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(141, 19);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(274, 20);
            this.txtChannelName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Talkgroup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Timeout";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Re-key delay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Scan list";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Receive group";
            // 
            // txtChannelFrequency
            // 
            this.txtChannelFrequency.Location = new System.Drawing.Point(141, 45);
            this.txtChannelFrequency.Name = "txtChannelFrequency";
            this.txtChannelFrequency.Size = new System.Drawing.Size(274, 20);
            this.txtChannelFrequency.TabIndex = 9;
            // 
            // txtChannelTransmitOffset
            // 
            this.txtChannelTransmitOffset.Location = new System.Drawing.Point(141, 71);
            this.txtChannelTransmitOffset.Name = "txtChannelTransmitOffset";
            this.txtChannelTransmitOffset.Size = new System.Drawing.Size(274, 20);
            this.txtChannelTransmitOffset.TabIndex = 10;
            // 
            // txtChannelTalkgroup
            // 
            this.txtChannelTalkgroup.Location = new System.Drawing.Point(141, 97);
            this.txtChannelTalkgroup.Name = "txtChannelTalkgroup";
            this.txtChannelTalkgroup.Size = new System.Drawing.Size(274, 20);
            this.txtChannelTalkgroup.TabIndex = 11;
            // 
            // txtChannelTimeout
            // 
            this.txtChannelTimeout.Location = new System.Drawing.Point(141, 143);
            this.txtChannelTimeout.Name = "txtChannelTimeout";
            this.txtChannelTimeout.Size = new System.Drawing.Size(274, 20);
            this.txtChannelTimeout.TabIndex = 12;
            // 
            // txtChannelRekeyDelay
            // 
            this.txtChannelRekeyDelay.Location = new System.Drawing.Point(141, 169);
            this.txtChannelRekeyDelay.Name = "txtChannelRekeyDelay";
            this.txtChannelRekeyDelay.Size = new System.Drawing.Size(274, 20);
            this.txtChannelRekeyDelay.TabIndex = 13;
            // 
            // txtChannelScanList
            // 
            this.txtChannelScanList.Location = new System.Drawing.Point(141, 215);
            this.txtChannelScanList.Name = "txtChannelScanList";
            this.txtChannelScanList.Size = new System.Drawing.Size(274, 20);
            this.txtChannelScanList.TabIndex = 14;
            // 
            // txtChannelReceiveGroup
            // 
            this.txtChannelReceiveGroup.Location = new System.Drawing.Point(141, 241);
            this.txtChannelReceiveGroup.Name = "txtChannelReceiveGroup";
            this.txtChannelReceiveGroup.Size = new System.Drawing.Size(274, 20);
            this.txtChannelReceiveGroup.TabIndex = 15;
            // 
            // submitBugReportToolStripMenuItem
            // 
            this.submitBugReportToolStripMenuItem.Name = "submitBugReportToolStripMenuItem";
            this.submitBugReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.submitBugReportToolStripMenuItem.Text = "Submit bug report";
            this.submitBugReportToolStripMenuItem.Click += new System.EventHandler(this.submitBugReportToolStripMenuItem_Click);
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userGuideToolStripMenuItem.Text = "User guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.groupBoxChannel);
            this.Controls.Add(this.treeViewCodeplugs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugcoder";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextChannel.ResumeLayout(false);
            this.contextZone.ResumeLayout(false);
            this.groupBoxChannel.ResumeLayout(false);
            this.groupBoxChannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCodeplugs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDebugFormToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextChannel;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextZone;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItemDelete;
        private System.Windows.Forms.GroupBox groupBoxChannel;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChannelReceiveGroup;
        private System.Windows.Forms.TextBox txtChannelScanList;
        private System.Windows.Forms.TextBox txtChannelRekeyDelay;
        private System.Windows.Forms.TextBox txtChannelTimeout;
        private System.Windows.Forms.TextBox txtChannelTalkgroup;
        private System.Windows.Forms.TextBox txtChannelTransmitOffset;
        private System.Windows.Forms.TextBox txtChannelFrequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem submitBugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}