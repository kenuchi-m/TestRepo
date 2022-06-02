using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using KLib2;

namespace MediaPreviewer
{
    internal class Class3
    {
    }

    public class PlayListItem
        : IDumpable
    {
        public int  LineNumber { get; set; } // ファイル番号
        public int Id { get; set; } // 識別子
        public string FileName { get; set; } // ファイル名
        public string Folder { get; set; } // フォルダ名
        public long  FileSize { get; set; } // ファイルサイズ
        public DateTime FileUpdateTime { get; set; } // 更新日時

        public string GetFullPath() // プルパス
        {
            return Folder + @"\" + FileName;
        }

        public void Dump(Log log)
        {
            log.tr("PlayListItem");
            log.tr("LineNumber={LineNumber}");
            log.tr("Id={Id}");
            log.tr("FileName={FileName}");
        }
    }
}
