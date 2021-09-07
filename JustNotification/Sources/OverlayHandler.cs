using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Windows.Forms;

namespace JustNotification
{
    class OverlayHandler
    {
        public static void Init()
        {
            string AppPath = Path.GetFullPath("./overlay/JustNotificationOverlay.exe");

            // ファイルチェック
            if (!File.Exists(AppPath))
            {
                MessageBox.Show("JustNotificationOverlay.exeが存在しないため、正常にオーバーレイを起動できませんでした。", "オーバーレイエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process.Start(AppPath);
        }
    }
}