using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using KLib2;

using System.Windows.Forms;

namespace MediaPreviewer
{
    internal class Class2
    {
    }

    public class FormSettings: ISerializeable
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public void Serialize(Archive ar)
        {
            ar.Put(X);
            ar.Put(Y);
            ar.Put(Width);
            ar.Put(Height);
        }

        public void Deserialize(Archive ar)
        {
            ar.Get(out X);
            ar.Get(out Y);
            ar.Get(out Width);
            ar.Get(out Height);
        }
    }

    public class AppSettings: ISerializeable, IDumpable
    {
//        public AppSettings mediaCtlForm = Form1.GetAppSettings();
        public FormSettings Settings {get; set;} // フォーム情報

        public int CurrentFileIndex {get;set;} // 現在の行位置
        public string RootFolder {get; set;} // メディアファイルの場所

        public AppSettings()
        {
            //            formSettings = new FormSettings();
            RootFolder = "";
        }

        public void Serialize(Archive ar)
        {
            Settings.Serialize(ar);
            ar.Put(CurrentFileIndex);
            ar.Put(RootFolder);
//            ar.Put("Dummy");
        }

        public void Deserialize(Archive ar)
        {
            Settings = new FormSettings();
            Settings.Deserialize(ar);
            int index;
            ar.Get(out index);
            CurrentFileIndex = index;

            string sFolder;
            ar.Get(out sFolder);
            RootFolder = sFolder;
        }

        public void Dump(Log log)
        {
            log.tr("RootFolder=[{0}]", RootFolder);
        }
    }
}
