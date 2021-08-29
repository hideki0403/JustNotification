﻿using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;
using Windows.UI.Notifications.Management;

namespace JustNotification
{
    class Notification
    {
        public static bool AccessAllowed { get; private set; } = false;
        public static bool IsEnableGetNotification = true;
        private static UserNotificationListener userNotificationListener = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static async Task<bool> Init()
        {
            if (!ApiInformation.IsTypePresent("Windows.UI.Notifications.Management.UserNotificationListener"))
            {
                AccessAllowed = false;
                userNotificationListener = null;
                return false;
            }

            userNotificationListener = UserNotificationListener.Current;
            UserNotificationListenerAccessStatus accessStatus = await userNotificationListener.RequestAccessAsync();

            if (accessStatus != UserNotificationListenerAccessStatus.Allowed)
            {
                AccessAllowed = false;
                userNotificationListener = null;
                return false;
            }
            AccessAllowed = true;

            GetNotification();

            return true;
        }

        public static async void GetNotification()
        {
            List<uint> notificationIds = new();
            bool init = false;

            while (IsEnableGetNotification)
            {
                IReadOnlyList<UserNotification> userNotifications = await userNotificationListener.GetNotificationsAsync(NotificationKinds.Toast);

                // 初回取得時には既にあった通知は投げないようにする
                if(!init)
                {
                    foreach (var n in userNotifications) notificationIds.Add(n.Id);
                    init = true;
                }
                
                foreach (var n in userNotifications)
                {
                    if (!notificationIds.Contains(n.Id))
                    {
                        ShowNotification(n);
                        notificationIds.Add(n.Id);
                    }
                }

                Thread.Sleep(Properties.Settings.Default.interval);
            }
        }

        private static async void ShowNotification(UserNotification n)
        {
            var notificationBinding = n.Notification.Visual.GetBinding(KnownNotificationBindings.ToastGeneric);
            if (notificationBinding != null)
            {
                IReadOnlyList<AdaptiveNotificationText> textElements = notificationBinding.GetTextElements();

                string nameText = n.AppInfo.DisplayInfo.DisplayName;
                string titleText = textElements.FirstOrDefault()?.Text;
                string bodyText = string.Join("\n", textElements.Skip(1).Select(t => t.Text));
                string appIcon = await Utils.GetLogoAsync(n);

                logger.Trace($"NotificationDetected: {nameText}");
                XSNotifications.Show(titleText, bodyText, nameText, appIcon);
            }
        }
    }
}