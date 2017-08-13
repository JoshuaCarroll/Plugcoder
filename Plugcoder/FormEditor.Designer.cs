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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextChannel.SuspendLayout();
            this.contextZone.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDebugFormToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openDebugFormToolStripMenuItem
            // 
            this.openDebugFormToolStripMenuItem.Name = "openDebugFormToolStripMenuItem";
            this.openDebugFormToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(433, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}