using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPreviewer
{
    public partial class PropForm : Form
    {
        public int LineNumber { get; set; }
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Folder { get; set; }
        public long FileSize { get; set; }
        public DateTime FileUpdateTime { get; set; }

        public PropForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close();
            Hide();
        }

        public void CommitMember ()
        {
            txtLineNumber.Text = LineNumber.ToString();
            txtFileID.Text = Id.ToString();
            txtFileName.Text = FileName;
            txtFolder.Text = Folder;
            txtFileSize.Text = FileSize.ToString("#,0");
            txtUpdateTime.Text = FileUpdateTime.ToString();
        }
    }
}
