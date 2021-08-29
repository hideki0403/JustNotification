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

            if (Properties.Settings.Default.enable_title)
            {
                notification.Title += $" - {nameText ?? ""}";
            }

            if (appIcon != "")
            {
                notification.UseBase64Icon = true;
                notification.Icon = appIcon ?? "";
            }

            XSOverlay.SendNotification(notification);
        }
    }
}
