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
using System.Media;

namespace MediaPreviewer
{
    public partial class MediaPlayerForm : Form
    {
        private SoundPlayer player = null;

        public MediaPlayerForm()
        {
            InitializeComponent();
        }

        private void mnuPlayMediaFile_Click(object sender, EventArgs e)
        {
            Log.t("メディアファイルの再生");

            //再生されているときは止める
            if (player != null)
                mnuPStopMediaFile_Click(null, null);

            //読み込む
//            string sFileName = @"Media\BadPlug1.wav";
            string sFileName = @"Media\AP01H4_G.mid";
            player = new SoundPlayer(sFileName);
            //非同期再生する
            player.Play();

            //次のようにすると、ループ再生される
            //player.PlayLooping();

            //次のようにすると、最後まで再生し終えるまで待機する
            //player.PlaySync();        }
        }

        private void mnuPStopMediaFile_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
    }
}

