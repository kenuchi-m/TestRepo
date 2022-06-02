namespace MediaPreviewer
{
    partial class MediaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaControl));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayOne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebug01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDebug02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReadMediaFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowPropForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRootFOlder = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnurShowPropForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayingFileName = new System.Windows.Forms.Label();
            this.txtFPlayingFileName = new System.Windows.Forms.TextBox();
            this.lblRowID = new System.Windows.Forms.Label();
            this.txtPlayingID = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chbLoopMode = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlyaNext = new System.Windows.Forms.Button();
            this.btnPlayPrev = new System.Windows.Forms.Button();
            this.chkAutoForm = new System.Windows.Forms.CheckBox();
            this.btnJumpLineNumber = new System.Windows.Forms.Button();
            this.txtJumpToLineNumber = new System.Windows.Forms.TextBox();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnDoSerch = new System.Windows.Forms.Button();
            this.rdbFirst = new System.Windows.Forms.RadioButton();
            this.rdbSlow = new System.Windows.Forms.RadioButton();
            this.chkPlayByLeftButton = new System.Windows.Forms.CheckBox();
            this.chkEnableDragAndDrop = new System.Windows.Forms.CheckBox();
            this.chkIgnoreChar = new System.Windows.Forms.CheckBox();
            this.pnlSerachOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlSerachOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(14, 18);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(442, 126);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTest,
            this.mnuAction,
            this.mnuSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTest
            // 
            this.mnuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayOne,
            this.mnuStop,
            this.mnuDebug01,
            this.mnuDebug02});
            this.mnuTest.Name = "mnuTest";
            this.mnuTest.Size = new System.Drawing.Size(55, 24);
            this.mnuTest.Text = "テスト";
            this.mnuTest.Visible = false;
            // 
            // mnuPlayOne
            // 
            this.mnuPlayOne.Name = "mnuPlayOne";
            this.mnuPlayOne.Size = new System.Drawing.Size(250, 26);
            this.mnuPlayOne.Text = "再生";
            this.mnuPlayOne.Click += new System.EventHandler(this.mnuPlayOne_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(250, 26);
            this.mnuStop.Text = "停止";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // mnuDebug01
            // 
            this.mnuDebug01.Name = "mnuDebug01";
            this.mnuDebug01.Size = new System.Drawing.Size(250, 26);
            this.mnuDebug01.Text = "デバッグ01 設定ファイルっる";
            this.mnuDebug01.Click += new System.EventHandler(this.mnuDebug01_Click);
            // 
            // mnuDebug02
            // 
            this.mnuDebug02.Name = "mnuDebug02";
            this.mnuDebug02.Size = new System.Drawing.Size(250, 26);
            this.mnuDebug02.Text = "デバッグ02 ソート";
            this.mnuDebug02.Click += new System.EventHandler(this.mnuDebug02_Click);
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReadMediaFiles,
            this.mnuShowPropForm});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(78, 24);
            this.mnuAction.Text = "アクション";
            // 
            // mnuReadMediaFiles
            // 
            this.mnuReadMediaFiles.Name = "mnuReadMediaFiles";
            this.mnuReadMediaFiles.Size = new System.Drawing.Size(231, 26);
            this.mnuReadMediaFiles.Text = "メディアファイルを読込む";
            this.mnuReadMediaFiles.Click += new System.EventHandler(this.mnuReadMediaFiles_Click);
            // 
            // mnuShowPropForm
            // 
            this.mnuShowPropForm.Name = "mnuShowPropForm";
            this.mnuShowPropForm.Size = new System.Drawing.Size(231, 26);
            this.mnuShowPropForm.Text = "ファイル情報を開く";
            this.mnuShowPropForm.Click += new System.EventHandler(this.mnuShowPropForm_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRootFOlder});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(53, 24);
            this.mnuSetting.Text = "設定";
            // 
            // mnuRootFOlder
            // 
            this.mnuRootFOlder.Name = "mnuRootFOlder";
            this.mnuRootFOlder.Size = new System.Drawing.Size(232, 26);
            this.mnuRootFOlder.Text = "メディアフォルダーの指定";
            this.mnuRootFOlder.Click += new System.EventHandler(this.mnuRootFolder_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNumber,
            this.Id,
            this.FileName,
            this.Folder,
            this.FileSize,
            this.FileDate});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 284);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // LineNumber
            // 
            this.LineNumber.Frozen = true;
            this.LineNumber.HeaderText = "行番号";
            this.LineNumber.MinimumWidth = 6;
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            this.LineNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LineNumber.Width = 60;
            // 
            // Id
            // 
            this.Id.HeaderText = "識別子";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 65;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "ファイル名";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileName.Width = 180;
            // 
            // Folder
            // 
            this.Folder.HeaderText = "フォルダ";
            this.Folder.MinimumWidth = 6;
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            this.Folder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Folder.Width = 500;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "サイズ";
            this.FileSize.MinimumWidth = 6;
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FileSize.Width = 125;
            // 
            // FileDate
            // 
            this.FileDate.HeaderText = "更新日時";
            this.FileDate.MinimumWidth = 6;
            this.FileDate.Name = "FileDate";
            this.FileDate.ReadOnly = true;
            this.FileDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileDate.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnurShowPropForm,
            this.mnuShowExplorer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 52);
            // 
            // mnurShowPropForm
            // 
            this.mnurShowPropForm.Name = "mnurShowPropForm";
            this.mnurShowPropForm.Size = new System.Drawing.Size(205, 24);
            this.mnurShowPropForm.Text = "ファイル情報を表示";
            this.mnurShowPropForm.Click += new System.EventHandler(this.mnurShowPropForm_Click);
            // 
            // mnuShowExplorer
            // 
            this.mnuShowExplorer.Name = "mnuShowExplorer";
            this.mnuShowExplorer.Size = new System.Drawing.Size(205, 24);
            this.mnuShowExplorer.Text = "エクスプローラーの起動";
            this.mnuShowExplorer.Click += new System.EventHandler(this.mnuShowExplorer_Click);
            // 
            // lblPlayingFileName
            // 
            this.lblPlayingFileName.AutoSize = true;
            this.lblPlayingFileName.Location = new System.Drawing.Point(130, 198);
            this.lblPlayingFileName.Name = "lblPlayingFileName";
            this.lblPlayingFileName.Size = new System.Drawing.Size(57, 15);
            this.lblPlayingFileName.TabIndex = 19;
            this.lblPlayingFileName.Text = "ファイル：";
            // 
            // txtFPlayingFileName
            // 
            this.txtFPlayingFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFPlayingFileName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFPlayingFileName.Location = new System.Drawing.Point(133, 216);
            this.txtFPlayingFileName.Name = "txtFPlayingFileName";
            this.txtFPlayingFileName.ReadOnly = true;
            this.txtFPlayingFileName.Size = new System.Drawing.Size(947, 27);
            this.txtFPlayingFileName.TabIndex = 20;
            this.txtFPlayingFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFPlayingFileName_DragEnter);
            // 
            // lblRowID
            // 
            this.lblRowID.AutoSize = true;
            this.lblRowID.Location = new System.Drawing.Point(9, 195);
            this.lblRowID.Name = "lblRowID";
            this.lblRowID.Size = new System.Drawing.Size(60, 15);
            this.lblRowID.TabIndex = 17;
            this.lblRowID.Text = "行番号：";
            // 
            // txtPlayingID
            // 
            this.txtPlayingID.Location = new System.Drawing.Point(14, 221);
            this.txtPlayingID.Name = "txtPlayingID";
            this.txtPlayingID.ReadOnly = true;
            this.txtPlayingID.Size = new System.Drawing.Size(100, 22);
            this.txtPlayingID.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1092, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // chbLoopMode
            // 
            this.chbLoopMode.AutoSize = true;
            this.chbLoopMode.Location = new System.Drawing.Point(641, 31);
            this.chbLoopMode.Name = "chbLoopMode";
            this.chbLoopMode.Size = new System.Drawing.Size(94, 19);
            this.chbLoopMode.TabIndex = 1;
            this.chbLoopMode.Text = "単一ループ";
            this.chbLoopMode.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(846, 171);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(234, 39);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "■停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(581, 171);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(149, 39);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "再生>";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlyaNext
            // 
            this.btnPlyaNext.Location = new System.Drawing.Point(736, 171);
            this.btnPlyaNext.Name = "btnPlyaNext";
            this.btnPlyaNext.Size = new System.Drawing.Size(75, 39);
            this.btnPlyaNext.TabIndex = 15;
            this.btnPlyaNext.Text = "次>>";
            this.btnPlyaNext.UseVisualStyleBackColor = true;
            this.btnPlyaNext.Click += new System.EventHandler(this.btnPlyaNext_Click);
            // 
            // btnPlayPrev
            // 
            this.btnPlayPrev.Location = new System.Drawing.Point(500, 171);
            this.btnPlayPrev.Name = "btnPlayPrev";
            this.btnPlayPrev.Size = new System.Drawing.Size(75, 39);
            this.btnPlayPrev.TabIndex = 13;
            this.btnPlayPrev.Text = "<<前";
            this.btnPlayPrev.UseVisualStyleBackColor = true;
            this.btnPlayPrev.Click += new System.EventHandler(this.btnPlayPrev_Click);
            // 
            // chkAutoForm
            // 
            this.chkAutoForm.AutoSize = true;
            this.chkAutoForm.Location = new System.Drawing.Point(641, 57);
            this.chkAutoForm.Name = "chkAutoForm";
            this.chkAutoForm.Size = new System.Drawing.Size(177, 19);
            this.chkAutoForm.TabIndex = 2;
            this.chkAutoForm.Text = "ファイル情報を自動で開く";
            this.chkAutoForm.UseVisualStyleBackColor = true;
            // 
            // btnJumpLineNumber
            // 
            this.btnJumpLineNumber.Location = new System.Drawing.Point(328, 171);
            this.btnJumpLineNumber.Name = "btnJumpLineNumber";
            this.btnJumpLineNumber.Size = new System.Drawing.Size(128, 39);
            this.btnJumpLineNumber.TabIndex = 12;
            this.btnJumpLineNumber.Text = "指定行へジャンプ";
            this.btnJumpLineNumber.UseVisualStyleBackColor = true;
            this.btnJumpLineNumber.Click += new System.EventHandler(this.btnJumpLineNumber_Click);
            // 
            // txtJumpToLineNumber
            // 
            this.txtJumpToLineNumber.Location = new System.Drawing.Point(222, 180);
            this.txtJumpToLineNumber.Name = "txtJumpToLineNumber";
            this.txtJumpToLineNumber.Size = new System.Drawing.Size(100, 22);
            this.txtJumpToLineNumber.TabIndex = 11;
            // 
            // txtSeach
            // 
            this.txtSeach.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSeach.Location = new System.Drawing.Point(622, 110);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(377, 34);
            this.txtSeach.TabIndex = 9;
            // 
            // btnDoSerch
            // 
            this.btnDoSerch.Location = new System.Drawing.Point(1005, 107);
            this.btnDoSerch.Name = "btnDoSerch";
            this.btnDoSerch.Size = new System.Drawing.Size(75, 37);
            this.btnDoSerch.TabIndex = 10;
            this.btnDoSerch.Text = "検索";
            this.btnDoSerch.UseVisualStyleBackColor = true;
            this.btnDoSerch.Click += new System.EventHandler(this.btnDoSerch_Click);
            // 
            // rdbFirst
            // 
            this.rdbFirst.AutoSize = true;
            this.rdbFirst.Checked = true;
            this.rdbFirst.Location = new System.Drawing.Point(12, 3);
            this.rdbFirst.Name = "rdbFirst";
            this.rdbFirst.Size = new System.Drawing.Size(116, 19);
            this.rdbFirst.TabIndex = 6;
            this.rdbFirst.TabStop = true;
            this.rdbFirst.Text = "単一キーワード";
            this.rdbFirst.UseVisualStyleBackColor = true;
            this.rdbFirst.CheckedChanged += new System.EventHandler(this.rdbFirst_CheckedChanged);
            // 
            // rdbSlow
            // 
            this.rdbSlow.AutoSize = true;
            this.rdbSlow.Location = new System.Drawing.Point(12, 54);
            this.rdbSlow.Name = "rdbSlow";
            this.rdbSlow.Size = new System.Drawing.Size(88, 19);
            this.rdbSlow.TabIndex = 8;
            this.rdbSlow.Text = "正規表現";
            this.rdbSlow.UseVisualStyleBackColor = true;
            this.rdbSlow.CheckedChanged += new System.EventHandler(this.rdbSlow_CheckedChanged);
            // 
            // chkPlayByLeftButton
            // 
            this.chkPlayByLeftButton.AutoSize = true;
            this.chkPlayByLeftButton.Location = new System.Drawing.Point(641, 82);
            this.chkPlayByLeftButton.Name = "chkPlayByLeftButton";
            this.chkPlayByLeftButton.Size = new System.Drawing.Size(124, 19);
            this.chkPlayByLeftButton.TabIndex = 3;
            this.chkPlayByLeftButton.Text = "左クリックで再生";
            this.chkPlayByLeftButton.UseVisualStyleBackColor = true;
            // 
            // chkEnableDragAndDrop
            // 
            this.chkEnableDragAndDrop.AutoSize = true;
            this.chkEnableDragAndDrop.Checked = true;
            this.chkEnableDragAndDrop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableDragAndDrop.Location = new System.Drawing.Point(781, 31);
            this.chkEnableDragAndDrop.Name = "chkEnableDragAndDrop";
            this.chkEnableDragAndDrop.Size = new System.Drawing.Size(135, 19);
            this.chkEnableDragAndDrop.TabIndex = 4;
            this.chkEnableDragAndDrop.Text = "D&&Dを有効にする";
            this.chkEnableDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreChar
            // 
            this.chkIgnoreChar.AutoSize = true;
            this.chkIgnoreChar.Checked = true;
            this.chkIgnoreChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreChar.Location = new System.Drawing.Point(27, 29);
            this.chkIgnoreChar.Name = "chkIgnoreChar";
            this.chkIgnoreChar.Size = new System.Drawing.Size(137, 19);
            this.chkIgnoreChar.TabIndex = 7;
            this.chkIgnoreChar.Text = "大小の区別しない";
            this.chkIgnoreChar.UseVisualStyleBackColor = true;
            // 
            // pnlSerachOptions
            // 
            this.pnlSerachOptions.Controls.Add(this.rdbSlow);
            this.pnlSerachOptions.Controls.Add(this.rdbFirst);
            this.pnlSerachOptions.Controls.Add(this.chkIgnoreChar);
            this.pnlSerachOptions.Location = new System.Drawing.Point(922, 31);
            this.pnlSerachOptions.Name = "pnlSerachOptions";
            this.pnlSerachOptions.Size = new System.Drawing.Size(168, 73);
            this.pnlSerachOptions.TabIndex = 5;
            // 
            // MediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 563);
            this.Controls.Add(this.pnlSerachOptions);
            this.Controls.Add(this.chkEnableDragAndDrop);
            this.Controls.Add(this.chkPlayByLeftButton);
            this.Controls.Add(this.btnDoSerch);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.txtJumpToLineNumber);
            this.Controls.Add(this.btnJumpLineNumber);
            this.Controls.Add(this.chkAutoForm);
            this.Controls.Add(this.btnPlayPrev);
            this.Controls.Add(this.btnPlyaNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chbLoopMode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtPlayingID);
            this.Controls.Add(this.lblRowID);
            this.Controls.Add(this.txtFPlayingFileName);
            this.Controls.Add(this.lblPlayingFileName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MediaControl";
            this.Text = "メディアプレビューワ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MediaControl_FormClosing);
            this.Load += new System.EventHandler(this.MediaControl_Load);
            this.Resize += new System.EventHandler(this.MediaControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSerachOptions.ResumeLayout(false);
            this.pnlSerachOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTest;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuReadMediaFiles;
        private System.Windows.Forms.Label lblPlayingFileName;
        private System.Windows.Forms.TextBox txtFPlayingFileName;
        private System.Windows.Forms.Label lblRowID;
        private System.Windows.Forms.TextBox txtPlayingID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox chbLoopMode;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuRootFOlder;
        private System.Windows.Forms.ToolStripMenuItem mnuDebug01;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlyaNext;
        private System.Windows.Forms.Button btnPlayPrev;
        private System.Windows.Forms.ToolStripMenuItem mnuShowPropForm;
        private System.Windows.Forms.CheckBox chkAutoForm;
        private System.Windows.Forms.Button btnJumpLineNumber;
        private System.Windows.Forms.TextBox txtJumpToLineNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuDebug02;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Button btnDoSerch;
        private System.Windows.Forms.RadioButton rdbFirst;
        private System.Windows.Forms.RadioButton rdbSlow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShowExplorer;
        private System.Windows.Forms.CheckBox chkPlayByLeftButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.CheckBox chkEnableDragAndDrop;
        private System.Windows.Forms.CheckBox chkIgnoreChar;
        private System.Windows.Forms.ToolStripMenuItem mnurShowPropForm;
        private System.Windows.Forms.Panel pnlSerachOptions;
    }
}