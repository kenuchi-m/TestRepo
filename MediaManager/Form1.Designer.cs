namespace MediaPreviewer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowMediaWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowMediaWindow02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDbRead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDbWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestLinq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoopByLinq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOther = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowMediaControl = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMedia,
            this.mnuTest,
            this.mnuOther});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMedia
            // 
            this.mnuMedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowMediaWindow,
            this.mnuShowMediaWindow02});
            this.mnuMedia.Name = "mnuMedia";
            this.mnuMedia.Size = new System.Drawing.Size(67, 24);
            this.mnuMedia.Text = "メディア";
            // 
            // mnuShowMediaWindow
            // 
            this.mnuShowMediaWindow.Name = "mnuShowMediaWindow";
            this.mnuShowMediaWindow.Size = new System.Drawing.Size(253, 26);
            this.mnuShowMediaWindow.Text = "メディアプレビュワーの表示";
            this.mnuShowMediaWindow.Click += new System.EventHandler(this.mnuShowMediaWindow_Click);
            // 
            // mnuShowMediaWindow02
            // 
            this.mnuShowMediaWindow02.Name = "mnuShowMediaWindow02";
            this.mnuShowMediaWindow02.Size = new System.Drawing.Size(253, 26);
            this.mnuShowMediaWindow02.Text = "メディアウインドウの表示 02";
            this.mnuShowMediaWindow02.Visible = false;
            this.mnuShowMediaWindow02.Click += new System.EventHandler(this.mnuShowMediaWindow02_Click);
            // 
            // mnuTest
            // 
            this.mnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabaseAccess,
            this.mnuTestLinq});
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(55, 24);
            this.mnuTest.Text = "テスト";
            this.mnuTest.Visible = false;
            // 
            // mnuDatabaseAccess
            // 
            this.mnuDatabaseAccess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDbRead,
            this.mnuDbWrite});
            this.mnuDatabaseAccess.Name = "mnuDatabaseAccess";
            this.mnuDatabaseAccess.Size = new System.Drawing.Size(224, 26);
            this.mnuDatabaseAccess.Text = "データベースの読み書き";
            // 
            // mnuDbRead
            // 
            this.mnuDbRead.Name = "mnuDbRead";
            this.mnuDbRead.Size = new System.Drawing.Size(167, 26);
            this.mnuDbRead.Text = "DBの読込み";
            this.mnuDbRead.Click += new System.EventHandler(this.mnuDbRead_Click);
            // 
            // mnuDbWrite
            // 
            this.mnuDbWrite.Name = "mnuDbWrite";
            this.mnuDbWrite.Size = new System.Drawing.Size(167, 26);
            this.mnuDbWrite.Text = "DBの書込み";
            this.mnuDbWrite.Click += new System.EventHandler(this.mnuDbWrite_Click);
            // 
            // mnuTestLinq
            // 
            this.mnuTestLinq.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoopByLinq});
            this.mnuTestLinq.Name = "mnuTestLinq";
            this.mnuTestLinq.Size = new System.Drawing.Size(224, 26);
            this.mnuTestLinq.Text = "Linqの確認";
            // 
            // mnuLoopByLinq
            // 
            this.mnuLoopByLinq.Name = "mnuLoopByLinq";
            this.mnuLoopByLinq.Size = new System.Drawing.Size(167, 26);
            this.mnuLoopByLinq.Text = "ループの基本";
            this.mnuLoopByLinq.Click += new System.EventHandler(this.mnuLoopByLinq_Click);
            // 
            // mnuOther
            // 
            this.mnuOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowVersion});
            this.mnuOther.Name = "mnuOther";
            this.mnuOther.Size = new System.Drawing.Size(61, 24);
            this.mnuOther.Text = "その他";
            // 
            // mnuShowVersion
            // 
            this.mnuShowVersion.Name = "mnuShowVersion";
            this.mnuShowVersion.Size = new System.Drawing.Size(146, 26);
            this.mnuShowVersion.Text = "バージョン";
            this.mnuShowVersion.Click += new System.EventHandler(this.mnuShowVersion_Click);
            // 
            // btnShowMediaControl
            // 
            this.btnShowMediaControl.Location = new System.Drawing.Point(61, 82);
            this.btnShowMediaControl.Name = "btnShowMediaControl";
            this.btnShowMediaControl.Size = new System.Drawing.Size(364, 64);
            this.btnShowMediaControl.TabIndex = 1;
            this.btnShowMediaControl.Text = "メディアプレビュワーの表示";
            this.btnShowMediaControl.UseVisualStyleBackColor = true;
            this.btnShowMediaControl.Click += new System.EventHandler(this.btnShowMediaControl_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(61, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(364, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 336);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowMediaControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "メディアランチャー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTest;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseAccess;
        private System.Windows.Forms.ToolStripMenuItem mnuDbRead;
        private System.Windows.Forms.ToolStripMenuItem mnuDbWrite;
        private System.Windows.Forms.ToolStripMenuItem mnuMedia;
        private System.Windows.Forms.ToolStripMenuItem mnuShowMediaWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuShowMediaWindow02;
        private System.Windows.Forms.Button btnShowMediaControl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOther;
        private System.Windows.Forms.ToolStripMenuItem mnuShowVersion;
        private System.Windows.Forms.ToolStripMenuItem mnuTestLinq;
        private System.Windows.Forms.ToolStripMenuItem mnuLoopByLinq;
    }
}

