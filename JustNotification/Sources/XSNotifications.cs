using XSNotifications;

namespace JustNotification
{
    class XSNotifications
    {
        private static XSNotifier XSOverlay = new();

        public static void Show(string titleText, string bodyText, string nameText,string appIcon)
        {
            XSNotification notification = new();
            notification.Title = titleText ?? "";
            notification.Content = bodyText ?? "";
            notification.Timeout = Properties.Settings.Default.timeout / 1000f;

            // 設定でソフト名を有効にしていて、なおかつソフト名がnullでなければソフト名を付け足す
            if (Properties.Settings.Default.enable_title && nameText != null)
            {
                notification.Title += $" - {nameText ?? ""}";
            }

            // アイコンが使用できればアイコンを付ける
            if (appIcon != "")
            {
                notification.UseBase64Icon = true;
                notification.Icon = appIcon ?? "";
            }

            XSOverlay.SendNotification(notification);
        }
    }
}
