namespace MediaPreviewer
{
    partial class MediaPlayerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayMediaFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPStopMediaFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTest
            // 
            this.mnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayMediaFile,
            this.mnuPStopMediaFile});
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(55, 24);
            this.mnuTest.Text = "テスト";
            // 
            // mnuPlayMediaFile
            // 
            this.mnuPlayMediaFile.Name = "mnuPlayMediaFile";
            this.mnuPlayMediaFile.Size = new System.Drawing.Size(224, 26);
            this.mnuPlayMediaFile.Text = "メディアファイルの再生";
            this.mnuPlayMediaFile.Click += new System.EventHandler(this.mnuPlayMediaFile_Click);
            // 
            // mnuPStopMediaFile
            // 
            this.mnuPStopMediaFile.Name = "mnuPStopMediaFile";
            this.mnuPStopMediaFile.Size = new System.Drawing.Size(224, 26);
            this.mnuPStopMediaFile.Text = "メディアファイルの停止";
            this.mnuPStopMediaFile.Click += new System.EventHandler(this.mnuPStopMediaFile_Click);
            // 
            // MediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MediaPlayerForm";
            this.Text = "MediaPlayerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTest;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayMediaFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPStopMediaFile;
    }
}