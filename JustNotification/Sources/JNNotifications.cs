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
    class JNNotifications
    {
        private struct JNMessage
        {
            public float timeout { get; set; }
            public string title { get; set; }
            public string content { get; set; }
        }

        private const int Port = 42030;

        public static void Show(string titleText, string bodyText, string nameText)
        {
            IPAddress broadcastIP = IPAddress.Parse("127.0.0.1");
            Socket broadcastSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint endPoint = new IPEndPoint(broadcastIP, Port);

            JNMessage notification = new JNMessage();

            notification.title = titleText ?? "";
            notification.content = bodyText ?? "";
            notification.timeout = Properties.Settings.Default.timeout / 1000f;

            // 設定でソフト名を有効にしていて、なおかつソフト名がnullでなければソフト名を付け足す
            if (Properties.Settings.Default.enable_title && nameText != null)
            {
                notification.title += $" - {nameText ?? ""}";
            }

            byte[] byteBuffer = JsonSerializer.SerializeToUtf8Bytes(notification);
            broadcastSocket.SendTo(byteBuffer, endPoint);
        }
    }
}
