using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using KLib2;

namespace MediaPreviewer
{
    internal class Class4
    {
    }

    public static class MPCommon
    {
        public static string AppSettingFileName()
        {
            return @"Settings.bin";
        }
    }

    public class KStopwatch: Stopwatch, IDumpable
    {
        public void Dump(Log log)
        {
            log.DumpCheckIn();

            TimeSpan ts = Elapsed;

            log.tr("タイム：時={0},分={1},秒={2}, ミリ={3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            log.DumpCheckOut();
        }
    }
}
