using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using KLib2;
// using System.Data.OleDb;

using AxWMPLib;
using System.Windows;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;

namespace MediaPreviewer
{
    internal class Class1
    {
    }

    // メディアファイルの再生制御を行うクラス
    public class MediaFileCtl
        : IDumpable
    {
        private AxWindowsMediaPlayer wmPlayer; // メディアプレイヤーコントロール
                                               //        List<string> aPlayList; // プレイリスト
        int iPlayCounter = 0; // 
        List<string> aPlaylist;　// プレイリスト

        enum PlayStatus
        {
            Playing = 0,
            Stoped,
        }
        PlayStatus status = PlayStatus.Stoped;
        PlayStatus staLoop = PlayStatus.Stoped;

        Timer timer;
        List<PlayListItem> plPlayList; //     プレイリスト詳細

        Dictionary<int, PlayListItem> dicPlaylist;

        public MediaFileCtl(AxWindowsMediaPlayer wmp)
        {
            this.wmPlayer = wmp;

            // タイマーの初期化
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 500;
            //            timer.Start();


            // プレイリストの初期化
            aPlaylist = new List<string>();

#if false
            aPlaylist.Add(@"Media\9thWave_02_EMPH.mp3");
            aPlaylist.Add(@"Media\AP01H4_G.mid");
            aPlaylist.Add(@"Media\BadPlug1.wav");
            aPlaylist.Add(@"Media\DEM_H4_G.MID");
#endif
        }

        // 指定したフォルダ以下のファイルを検索しプレイリストファイルを作成する
        public void CreatePlaylistFromFolder(string sFolderName = null)
        {
            AppSettings ast = Form1.GetAppSettings();
            string sRootFoler = ast.RootFolder;

            // 拡張子別に読込む

            aPlaylist = new List<string>();
            SearchFiles(sRootFoler, "*.wav", ref aPlaylist);
            SearchFiles(sRootFoler, "*.aif", ref aPlaylist);
            SearchFiles(sRootFoler, "*.mid", ref aPlaylist);

            // テスト
            // SearchFiles(sRootFoler, "*.mp3", ref aPlaylist); // 検索した結果がおかしい
            // SearchFiles(sRootFoler, "*.avi", ref aPlaylist); // 画像は表示されないが音声は流れる

            Log.t("メディアファイルを検索完了: ファイル数={0}", aPlaylist.Count);
        }

        private void SearchFiles(string sRootFoler, string sExtention, ref List<string> aResultFiles)
        {
            try
            {
                IEnumerable<string> eResultFiles = Directory.EnumerateFileSystemEntries(sRootFoler, sExtention, SearchOption.AllDirectories);

                int i = 0;
                foreach (string sFile in eResultFiles)
                {
                    aResultFiles.Add(sFile);
                    i++;
                }
            }
            catch (Exception)
            {
                Log.w("ファイル検索に失敗しました");
                return; // 何もしない
            }
        }

        public void OnStart(_WMPOCXEvents_PlayStateChangeEvent ea)
        {
            string sFileName = aPlaylist[iPlayCounter];
            Log.t("メディアプレイヤーの開始イベントを補足しました. ファイル名=[{0}]", sFileName);
            //            wmp.URL = sFileName; // ファイルの再生 // ここでは実行しない
            status = PlayStatus.Playing;
        }

        public void OnStop(_WMPOCXEvents_PlayStateChangeEvent ea, System.Windows.Forms.Timer tm, bool boLoopMode)
        {
            Log.t("メディアプレイヤーの停止イベントを補足しました. ea==[{0}]", ea.ToString());
            status = PlayStatus.Stoped;

            if (boLoopMode)
                ; // 何もしない
            else
            {
                if (iPlayCounter < aPlaylist.Count - 1)
                    // iPlayCounter++; // 何もしない
                    iPlayCounter++;
                else
                    iPlayCounter = 0;
            }

            //            PlayFile();
            status = PlayStatus.Stoped;

            //            tm.Start();
            timer.Start();
        }

        // 再生
        public void PlayFile(int index = 0)
        {
            iPlayCounter = index;

            string sFileName = "";
            try
            {
                sFileName = aPlaylist[iPlayCounter];
            }
            catch(Exception)
            {
                Log.w("メディアファイルを特定できませんでした. インデックス={0}", iPlayCounter);
            }

            if(sFileName != "")
            {
                if(File.Exists(sFileName)) // ファイルが存在する場合
                {
                    var fi = new FileInfo(sFileName);
                    if (fi.Length == 0) // ファイルサイズ０の場合
                    {
                        PlayFile(iPlayCounter + 1); // 次のファイルを再生
                        return;
                    }
                }
                else
                    Log.w("ファイルが見つかりません.ファイル名 =[{0}]", sFileName);
            }
            else
                return;


            Log.t("メディアを再生します. ファイル名=[{0}]", sFileName);
            try
            {
                wmPlayer.URL = sFileName; // ファイルの再生
            }
            catch(Exception)
            {
                Log.w("メディアファイルを再生できません");
            }

            status = PlayStatus.Playing; // 再生状態へ
            staLoop = PlayStatus.Playing; // 再生状態へ
        }

        // 停止
        public void StopFile()
        {
            Log.t("メディア再生を停止します.");
            staLoop = PlayStatus.Stoped;
        }

        public string GetPlayingFileName()
        {
            return wmPlayer.URL;
        }

        public int GetPlayingIndex()
        {
            return iPlayCounter;
        }

        public void SetPlayingIndex(int index)
        {
            iPlayCounter = index;
        }

#if false
        public void OnTimeTick(EventArgs ea, System.Windows.Forms.Timer tm)
        {
            Log.t("タイマーイベントが発生しました.");
#if false
            tm.Stop();

            status = PlayStatus.Stoped; // 停止状態へ

            PlayFile(); // 次のファイルを再生
#endif
        }
#endif

        public void Timer_Tick(object sender, EventArgs e)
        {
            Log.t("タイマーイベント（非GUI）が発生しました.");
            timer.Stop();

            status = PlayStatus.Stoped; // 停止状態へ

            if (staLoop == PlayStatus.Stoped) // 停止ボタン押下
                return;

            PlayFile(GetPlayingIndex()); // 次のファイルを再生
        }

        public void CreatePlaylist(
            DataGridView dgv,
            ToolStripStatusLabel tssl,
            string sFilterText = null,
            bool boFilterOption = true,
            bool boIgnoreChar = true)
        {
            //            List<PlayListItem> plPlayLis = new List<PlayListItem>();
            var wf = new WaitForm();
            wf.Show();
            wf.Activate();

            TaskUtil.DoEvents();

            string sFilterText2 = null; // 全てを表示する（フィルターを掛けない）
            if (sFilterText != null)
                sFilterText2 = sFilterText.Trim();

            dgv.Visible = false; // 処理中は非表示にする

            plPlayList = new List<PlayListItem>(); // プレイリストの初期化
            dicPlaylist = new Dictionary<int, PlayListItem>(); // 辞書のプレイリストの初期化

            CreatePlaylistFromFolder(); // プレイリスト作成
            
            dgv.Rows.Clear();
            int i = 0;
            string sFileName;
            string sFolder;

            int iProblem = 0;

            Regex reg = null;
            if(sFilterText2 != null && !boFilterOption) // 非全件表示かつ正規表現の場合
                reg = new Regex(sFilterText2);

            Log.t("ループ計測開始");
            var sw = new KStopwatch();
            sw.Start();

            foreach (string sFilePath in aPlaylist)
            {
                sFileName = Path.GetFileName(sFilePath);
                sFolder = Path.GetDirectoryName(sFilePath);

                string sFullPath = sFolder + @"\" + sFileName; // フルパス

                if (sFilterText2 == null) // 全て表示する
                    goto Proccess_Start;

                
                if(boFilterOption) // 単純高速の場合
                {
                    if (boIgnoreChar) // 大文字小文字の区別はしない場合
                    { 
                        string sFullPathUpper = sFullPath.ToUpper();
                        string sFilterText2Upper = sFilterText2.ToUpper();

                        if (!sFullPathUpper.Contains(sFilterText2Upper)) // フィルター文字列が含まれていない場合
                            continue; // 結果に含めない
                    }
                    else
                    {
                        if (!sFullPath.Contains(sFilterText2)) // フィルター文字列が含まれていない場合
                            continue; // 結果に含めない
                    }
                }
                else
                {
                    // 複雑低速（正規表現）
//                    bool result = Regex.IsMatch(sFullPath, sFilterText2);
                    if(reg != null)
                    {
                        bool result = reg.IsMatch(sFullPath);
                        if (!result)
                            continue; // 結果に含めない
                    }
                }

            Proccess_Start:

                    var pli = new PlayListItem();
//                pli.FlNum = i.ToString();
                pli.LineNumber = i;
                pli.Id = pli.LineNumber;
                pli.FileName = sFileName;
                pli.Folder = sFolder;

                //                string sFullPath = sFolderName + sFileName; 
                try
                {
                    var fi = new FileInfo(pli.GetFullPath());
                    pli.FileSize = (int)fi.Length;
                    pli.FileUpdateTime = fi.LastWriteTime;
                }
                catch (Exception ex) // *.wav などのようにフォルダなのに拡張子がある場合
                {
                    Log.w("フォルダが不正です。このアイテムは無視します: フォルダ名=[{0}]: ファイル名=[{1}]: ErrorMsg=[{2}]", sFolder, sFileName, ex.Message);
                    iProblem++;
                    continue; // 次のアイテムに進む
                }

                plPlayList.Add(pli);
                dicPlaylist.Add(pli.Id, pli); // 辞書に追加

                string sFileSize = pli.FileSize.ToString("#,0");
                string sUpdateTime = pli.FileUpdateTime.ToString();

                dgv.Rows.Add(pli.LineNumber, pli.Id, sFileName, sFolder, sFileSize, sUpdateTime);

                i++;
            }

#if false // 不具合対処しきれず
            // 2回目のLINQによる検索とソート 少し難しい
            var plPlayList3 = new List<PlayListItem>();

            // var plPlayList2 = plPlayList.OrderBy(fil => fil.FileSize).Select(fil => fil);
            IEnumerable<PlayListItem> plResult;
            if (sFilterText2 != null)
            {
                var reg = new Regex(sFilterText);
                plResult = plPlayList.Where(fil => reg.IsMatch(fil.GetFullPath())).OrderBy(fil => fil.FileSize).Select(fil => fil);
            }
            else
            {
                plResult = plPlayList;
            }
            //    return; // 全検索

            //            plPlayList2 = plResult;

            string sFileName2;
            string sFolder2;
            
            int j = 0;
            //foreach (var pli in plPlayList2)
            foreach (PlayListItem pli in plResult)
            {
                string sFilePath = pli.GetFullPath();

                sFileName2 = Path.GetFileName(sFilePath);
                sFolder2 = Path.GetDirectoryName(sFilePath);

                pli.LineNumber = j;
                pli.Id = pli.LineNumber;
                pli.FileName = sFileName2;
                pli.Folder = sFolder2;

                //                string sFullPath = sFolderName + sFileName; 
                var fi = new FileInfo(pli.GetFullPath());
                pli.FileSize = (int)fi.Length;
                pli.FileUpdateTime = fi.LastWriteTime;

                plPlayList.Add(pli);
//                dicPlaylist.Add(pli.Id, pli); // 辞書に追加

                string sFileSize = pli.FileSize.ToString("#,0");
                string sUpdateTime = pli.FileUpdateTime.ToString();

                dgv.Rows.Add(pli.LineNumber, pli.Id, sFileName2, sFolder2, sFileSize, sUpdateTime);

                plPlayList3.Add(pli);
                j++;    
            }
            plPlayList = plPlayList3;
#endif
            sw.Stop();
            sw.Dump(Log.GetLog());
            Log.t("ループ計測終了");

            wf.Close();

            if(iProblem > 0)
                Log.w("{0}個の問題がありました", iProblem);

            string sStatusMsg = string.Format("{0}個の項目", plPlayList.Count.ToString("#,0"));
            tssl.Text = sStatusMsg;

            if(plPlayList.Count != 0) // ゼロ件以外の場合
                dgv.Visible = true;
        }

        // 選択されているファイル情報を取得する
        public PlayListItem GetCurrentItem()
        {
                // return plPlayList[iPlayCounter];
                var pli = plPlayList[iPlayCounter];
                // var pli2 = dicPlaylist[pli.Id];

                // return pli2;
                return pli;
            // return dicPlaylist[plPlayList[iPlayCounter].Id];
        }

        public void Dump(Log log)
        {
            log.tr("MediaFileCtlのダンプ");
            log.tr("dicPlaylistのダンプ");
            log.tr("dicPlaylist辞書の要素数={0}", dicPlaylist.Count);

            foreach (KeyValuePair<int, PlayListItem> kvp in dicPlaylist)
            {
                int id = kvp.Key;
                var pli = kvp.Value;
                string sFilename = pli.FileName;
                log.tr($"LineNumber={pli.LineNumber}id={id}: FileName=[{sFilename}]: Folder=[{pli.Folder}]");
            }
        }

        public void SetId(int iRow, DataGridView dvi)
        {
            var pli = plPlayList[iRow];
//            pli
            var pli2 = dicPlaylist[pli.Id];
            pli2.Id = pli.Id;
            return;
        }
    }

}

