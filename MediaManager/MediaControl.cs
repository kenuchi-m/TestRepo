using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using KLib2;
using System.IO;
using System.Diagnostics;

namespace MediaPreviewer
{
    public partial class MediaControl : Form
    {
        private MediaFileCtl mfc;

        public MediaControl()
        {
            InitializeComponent();

        }

        private void mnuPlayOne_Click(object sender, EventArgs e)
        {
            // mfc.PlayFile(mfc.GetPlayingIndex()); // 選択行から再生開始

            mfc.SetPlayingIndex(dataGridView1.CurrentRow.Index);
            mfc.PlayFile(dataGridView1.CurrentRow.Index); // 選択行から再生開始
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            int iState = (int)e.newState;
            switch (iState)
            {
                case (int)WMPLib.WMPPlayState.wmppsPlaying:
                    //再生中に入った時
                    //                    Log.t("メディアプレイヤーの再生開始イベントを補足しました. State={0}", iState);
                    mfc.OnStart(e);

                    int index = mfc.GetPlayingIndex();
                    txtPlayingID.Text = index.ToString();
                    txtFPlayingFileName.Text = mfc.GetPlayingFileName();

                    // 選択行の更新
                    // GridUnSelectAll();
                    // dataGridView1.Rows[index].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];

                    // 再生行のスクロール
                    int iScrollMergin = 4;
                    if(index >= iScrollMergin)
                        dataGridView1.FirstDisplayedScrollingRowIndex = index - iScrollMergin;

                    if (chkAutoForm.Checked)
                        mnuShowPropForm_Click(null, null);

                    break;

                case (int)WMPLib.WMPPlayState.wmppsStopped:
                    //停止状態に入った時　
//                    Log.t("メディアプレイヤーの停止イベントを補足しました. State={0}", iState);
                    mfc.OnStop(e, timer1, chbLoopMode.Checked);
                    break;

                default:
//                    Log.t("メディアプレイヤーのイベントを補足しました. State={0}", iState);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
//            mfc.OnTimeTick(e, timer1);
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            // axWindowsMediaPlayer1.EndOfStream();
            // Close();
            mfc.StopFile();
            axWindowsMediaPlayer1.URL = "";
        }

        private void MediaControl_Load(object sender, EventArgs e)
        {
            // フォーム情報を設定ファイルから読込む
            string sFileName = MPCommon.AppSettingFileName();

            AppSettings ast = Form1.GetAppSettings();

            // const string sFileName = "Settings.bin";
            try
            {
                using (var fs = new FileStream(sFileName, FileMode.Open))
                {
                    var ar = new BinaryArchive(fs);
                    ast.Deserialize(ar);
                }

                var settings = ast.Settings;
                Left = settings.X;
                Top = settings.Y;
                Width = settings.Width;
                Height = settings.Height;

            }
            catch (FileNotFoundException)
            {
                Log.w("設定ファイルが見つかりません");
            }


            mfc = new MediaFileCtl(axWindowsMediaPlayer1);

            //           axWindowsMediaPlayer1.Location.X = dataGridView1.Location.X;
            // var loc = axWindowsMediaPlayer1.Location;
            // loc.X = dataGridView1.Location.X;

            // mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1);
            mnuReadMediaFiles_Click(null, null);

            // 選択行の復元
            GridUnSelectAll();
            try
            {
                //                dataGridView1.Rows[ast.CurrentFileIndex].Selected = true;
                // dataGridView1.CurrentRow.Index = ast.CurrentFileIndex;
                // dataGridView1.SelectedRows[0].Index = ast.CurrentFileIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[ast.CurrentFileIndex].Cells[0];
                mfc.SetPlayingIndex(ast.CurrentFileIndex);
            }
            catch
            {
                Log.w("設定カレント行が復元できません");
            }
        }

        private void mnuReadMediaFiles_Click(object sender, EventArgs e)
        {
            // mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1);
            mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Log.t("データグリッドでダブルクリックされました: Count={0}", dataGridView1.SelectedRows.Count);

#if false
            string sMessage;
            int index = dataGridView1.CurrentRow.Index;
            sMessage = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //            MessageBox.Show(sMessage);
#endif
            int iSelectedIndex = dataGridView1.SelectedRows[0].Index;
            //Log.t("iSelectedIndex={0}", iSelectedIndex);
            mfc.SetPlayingIndex(iSelectedIndex);
//            mnuShowPropForm_Click(null, null);
            if (!chkPlayByLeftButton.Checked)
                mnuPlayOne_Click(null, null); // 再生開始

        }

        // グリッドの全ての行を選択解除する
        public void GridUnSelectAll()
        {
            for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[i];
                if (row.Selected == true)
                    row.Selected = false;
            }
        }

        private void MediaControl_Resize(object sender, EventArgs e)
        {
            // var gvSize = new Size(Size.Width - 20, Height - 100);
            // dataGridView1.Size= gvSize;
        }

        private void MediaControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            // フォーム情報を保存する
            try
            {
                AppSettings ast = Form1.GetAppSettings();

                var settings = new FormSettings();
                settings.X = Left;
                settings.Y = Top;
                settings.Width = Width;
                settings.Height = Height;
                ast.Settings = settings;

                if(dataGridView1.CurrentRow == null) // ヌル値の場合
                    ast.CurrentFileIndex = 0;
                else
                    ast.CurrentFileIndex = dataGridView1.CurrentRow.Index;

                //            ast.RootFolder = ""; // ここにきてるならば設定されてなくてはならない

                // const string sFileName = "Settings.bin";
                string sFileName = MPCommon.AppSettingFileName();

                using (var fs = new FileStream(sFileName, FileMode.OpenOrCreate))
                {
                    var ar = new BinaryArchive(fs);
                    ast.Serialize(ar);
                }
            }
            catch (Exception)
            {
                Log.e("設定ファイルの保存に失敗しました");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mnuStop_Click(sender, e);
        }

        // メディアファイルの位置を設定する
        private void mnuRootFolder_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            var appSettiongs = Form1.GetAppSettings();

            //            settingForm.RootFolder = appSettiongs.RootFolder;

            bool boNeedUpdate = false;
            DialogResult result = settingForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                appSettiongs.RootFolder = settingForm.GetRootFolder();
                boNeedUpdate = true;
            }

            if(boNeedUpdate)
                mnuReadMediaFiles_Click(null, null); // 画面の更新
        }

        private void mnuDebug01_Click(object sender, EventArgs e)
        {
            var ast = Form1.GetAppSettings();
            ast.Dump(Log.GetLog());
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mnuPlayOne_Click(null, null);
        }

        private void btnPlyaNext_Click(object sender, EventArgs e)
        {
            mfc.PlayFile(mfc.GetPlayingIndex() + 1); // 選択行の次から再生開始
        }

        private void btnPlayPrev_Click(object sender, EventArgs e)
        {
            mfc.PlayFile(mfc.GetPlayingIndex() - 1); // 選択行の前から再生開始
        }

        private void txtFPlayingFileName_DragEnter(object sender, DragEventArgs e)
        {
#if false // D&Dのサンプル
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            //    e.Effect = DragDropEffects.Copy;
                e.Effect = DragDropEffects..Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
#endif
        }

        static PropForm propForm = null;

        private void mnuShowPropForm_Click(object sender, EventArgs e)
        {
            if(propForm == null)
                propForm = new PropForm();
            else
            {
                if(propForm.IsDisposed)
                    propForm = new PropForm();
            }

            var currentFile = mfc.GetCurrentItem();

            propForm.LineNumber = currentFile.LineNumber;
            propForm.Id = currentFile.Id;
            propForm.FileName = currentFile.FileName;
            propForm.Folder = currentFile.Folder;
            propForm.FileSize = currentFile.FileSize;
            propForm.FileUpdateTime = currentFile.FileUpdateTime;

            propForm.CommitMember(); // 設定したメンバを確定する

            propForm.Show();

            if(chkAutoForm.Checked)
                propForm.Activate();
        }

        private void btnJumpLineNumber_Click(object sender, EventArgs e)
        {
            // var currentFile = mfc.GetCurrentItem();
            int iToNumber = -1;
            try
            {
                iToNumber = int.Parse(txtJumpToLineNumber.Text);

                //            mfc.SetPlayingIndex(iToNumber);
                mfc.PlayFile(iToNumber);
            }
            catch (Exception ex)
            {
                Log.w("ジャンプできません: テキストボックス=[{0}]: Message=[{1}]: Number={2}", txtJumpToLineNumber.Text, ex.Message, iToNumber);
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
#if false
            // 行番号を更新する
            int i;
            int iCount = dataGridView1.Rows.Count;
            for(i = 0; i < iCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
//                string sId = dataGridView1.Rows[i].Cells[1].Value.ToString();
//                int iId = int.Parse(sId);
//                mfc.SetId(iId, dataGridView1);
            }

            Log.t("ソートしました");
#endif
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mnuDebug02_Click(object sender, EventArgs e)
        {
            mfc.Dump(Log.GetLog());
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //            Log.t("グリッドのカレント行の設定");
            //            Set
            //            dataGridView1.CurrentCell.
            if(chkPlayByLeftButton.Checked)
            {
                int index = mfc.GetPlayingIndex();
                mfc.PlayFile(index);
            }
        }

        // 検索
        private void btnDoSerch_Click(object sender, EventArgs e)
        {
            string sJouken = txtSeach.Text; // 検索条件
            // mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1, sJouken);
            // mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1, sJouken, rdbFirst.Checked);
            mfc.CreatePlaylist(dataGridView1, toolStripStatusLabel1, sJouken, rdbFirst.Checked, chkIgnoreChar.Checked);
        }

        private void mnuShowExplorer_Click(object sender, EventArgs e)
        {
            var currentItem = mfc.GetCurrentItem();
            string sForlder = "\"" + currentItem.Folder + "\""; // フォルダを特定
            string sProgramName = "Explorer.exe";

            Process.Start(sProgramName, sForlder);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) // データが空の場合
                return;

            // Log.t("カレント行が変わりました: Index={0}", dataGridView1.CurrentRow.Index);
            //Log.t("カレント行が変わりました: Index={0}", dataGridView1.SelectedRows[0].Index);
            //           mfc.SetPlayingIndex(dataGridView1.CurrentRow.Index);

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int iSelectedIndex = dataGridView1.SelectedRows[0].Index;
            // int iSelectedIndex = dataGridView1.CurrentRow.Index;
            // Log.t("カレント行が変わりました: Index2={0}", iSelectedIndex);
            // Log.t("iSelectedIndex={0}", iSelectedIndex);
            mfc.SetPlayingIndex(iSelectedIndex);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            Log.t("マウスダウンイベント補足");
            // return;

            if (e.Button == MouseButtons.Right) // 右ボタンが押された場合
                return; // 何もしない

            if(!chkEnableDragAndDrop.Checked) // D&Dを有効にしていない場合 
                return; // 何もしない

            // カレント行の特定
            var currentItem = mfc.GetCurrentItem();
            string sFullPath = currentItem.GetFullPath();

            // dataGridView1.DoDragDrop(sFullPath, DragDropEffects.Copy);

            // string[] paths = { @"D:\_NoBackup\MusicClip\Loops\Bass\ACID\DANCE\Synthesizer Bass\Alone Bass.wav" }; // ファイル・パスの文字列配列
            var paths = new string[] { sFullPath };
            DataObject dataObj = new DataObject(DataFormats.FileDrop, paths);

            dataGridView1.DoDragDrop(dataObj, DragDropEffects.Copy);

#if false
            using(var fs = new FileStream(sFullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                DoDragDrop(fs, DragDropEffects.Copy);
            }
#endif

#if false
            //DataObject dataObj = new DataObject(DataFormats.FileDrop);
            DataObject dataObj = new DataObject(DataFormats.FileDrop, sFullPath);

            //ドラッグを開始する
            DragDropEffects dde =
                DoDragDrop(dataObj, DragDropEffects.Copy);
#endif
        }

        private void rdbFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFirst.Checked)
                chkIgnoreChar.Enabled = true;
        }

        private void rdbSlow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSlow.Checked)
                chkIgnoreChar.Enabled = false;
        }

        private void mnurShowPropForm_Click(object sender, EventArgs e)
        {
            mnuShowPropForm_Click(sender, e);
        }
    }
}
