using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace MediaPreviewer
{
    public partial class SettingForm : Form
    {
//        public string RootFolder { get; set; }

        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnRootFolderRef_Click(object sender, EventArgs e)
        {
            AppSettings ast = Form1.GetAppSettings();

            folderBrowserDialog1.Description = "フォルダーを選択してください";
            folderBrowserDialog1.SelectedPath = ast.RootFolder;

            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                txtRootFolder.Text = folderBrowserDialog1.SelectedPath;
                ast.RootFolder = txtRootFolder.Text;
            }

#if false
            openFileDialog1.Title = "フォルダを選択してください.";
            openFileDialog1.FileName = "SelectFolder";
            openFileDialog1.Filter = "Folder |.";
            openFileDialog1.CheckPathExists = false;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.InitialDirectory = @"C:\";

            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
                MessageBox.Show(openFileDialog1.FileName);
#endif
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            AppSettings ast = Form1.GetAppSettings();
            txtRootFolder.Text = ast.RootFolder;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sFolderName = txtRootFolder.Text;
            if (!Directory.Exists(sFolderName)) // フォルダが存在しない場合 
            {
                MessageBox.Show("フォルダが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
        }

        // Media Fileの場所を取得
        public string GetRootFolder()
        {
            return txtRootFolder.Text;
        }
    }
}
