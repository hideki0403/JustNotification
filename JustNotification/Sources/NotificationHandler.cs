using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JustNotification
{
    class NotificationHandler
    {
        private struct JNMessage
        {
            public float timeout { get; set; }
            public string title { get; set; }
            public string content { get; set; }
        }

        private static IPC socket = new();

        public static void Show(string titleText, string bodyText, string nameText)
        {
            JNMessage notification = new JNMessage();

            notification.title = titleText ?? "";
            notification.content = bodyText ?? "";
            notification.timeout = Properties.Settings.Default.timeout / 1000f;

            // 設定でソフト名を有効にしていて、なおかつソフト名がnullでなければソフト名を付け足す
            if (Properties.Settings.Default.enable_title && nameText != null)
            {
                notification.title += $" - {nameText ?? ""}";
            }

            string json = JsonSerializer.Serialize(notification);
            _ = socket.Send(json);
        }
    }
}
