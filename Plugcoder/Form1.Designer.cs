namespace Plugcoder
{
    partial class Form1
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
            this.btnParse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRdtFilename = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnOpenEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(12, 66);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(97, 23);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 241);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "RDT";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Codeplug (RDT) files|*.rdt";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // lblRdtFilename
            // 
            this.lblRdtFilename.AutoSize = true;
            this.lblRdtFilename.Location = new System.Drawing.Point(125, 29);
            this.lblRdtFilename.Name = "lblRdtFilename";
            this.lblRdtFilename.Size = new System.Drawing.Size(0, 13);
            this.lblRdtFilename.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Select RDT file";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnOpenEditor
            // 
            this.btnOpenEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenEditor.Location = new System.Drawing.Point(436, 24);
            this.btnOpenEditor.Name = "btnOpenEditor";
            this.btnOpenEditor.Size = new System.Drawing.Size(76, 23);
            this.btnOpenEditor.TabIndex = 4;
            this.btnOpenEditor.Text = "Open editor";
            this.btnOpenEditor.UseVisualStyleBackColor = true;
            this.btnOpenEditor.Click += new System.EventHandler(this.btnOpenEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 348);
            this.Controls.Add(this.btnOpenEditor);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblRdtFilename);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnParse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRdtFilename;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOpenEditor;
    }
}

