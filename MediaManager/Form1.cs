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

namespace MediaPreviewer
{
    public partial class Form1 : Form
    {
//        AppSettings appSettings;
        public Form1()
        {
            InitializeComponent();

            //appSettings = new AppSettiongs();

            Log.SetDefaultLog(new FileLog()); // ファイルへログを吐くようにする
        }

        // アプリケーションの設定情報
#if false
        static Form1()
        {
            AppSettings appSettings = new AppSettings();
        }

        public static AppSettings GetAppSettings()
        {
            return appSettings;
        }

        public static AppSettings GetAppSettings()
        {
            AppSettings appSettings = null;
            // static AppSettings appSettings = null;
            // var appSettings = null;

            if (appSettings == null)
                appSettings = new AppSettings();

            return appSettings;
        }   
#endif
        // 静的オブジェクト
        static AppSettings appSettings = new AppSettings();
        public static AppSettings GetAppSettings()
        { return appSettings; }

        private void mnuDbRead_Click(object sender, EventArgs e)
        {
            Test.TestDbRead();
        }

        private void mnuDbWrite_Click(object sender, EventArgs e)
        {
            Test.TestDbWrite();
        }

        static MediaControl mediaControl = null;
        private void mnuShowMediaWindow_Click(object sender, EventArgs e)
        {
            // シングルフォーム（アプリ内で一つ）
            if(mediaControl == null)
                mediaControl = new MediaControl();

            if(mediaControl.IsDisposed)
                mediaControl = new MediaControl();

            // mediaControl.Show(this);
            mediaControl.Show();
            mediaControl.Activate();
        }

        private void mnuShowMediaWindow02_Click(object sender, EventArgs e)
        {
            var mpf = new MediaPlayerForm();
            mpf.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // mnuShowMediaWindow_Click(null, null); // デバッグ用
        }

        private void btnShowMediaControl_Click(object sender, EventArgs e)
        {
            mnuShowMediaWindow_Click(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuShowVersion_Click(object sender, EventArgs e)
        {
            var vsionForm = new VersionForm();
            vsionForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mediaControl != null)
            {
                if (!mediaControl.IsDisposed)
                    mediaControl.Close();
            }

        }

        private void mnuLoopByLinq_Click(object sender, EventArgs e)
        {
            Test.TestLinq();
        }
    }
}
