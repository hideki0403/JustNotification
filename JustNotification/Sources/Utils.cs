using System;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Foundation;
using Windows.Storage.Streams;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.Toolkit.Uwp.Notifications;

namespace JustNotification
{
    class Utils
    {
        public static async Task<string> GetLogoAsync(UserNotification app)
        {
            RandomAccessStreamReference stream = app.AppInfo.DisplayInfo.GetLogo(new Size(64, 64));

            // 通知のアイコンを取れるのはUWPのみで、それ以外はstreamがnullになるためnullチェックをする必要がある
            if (stream == null) return "";

            IRandomAccessStreamWithContentType content = await stream.OpenReadAsync();

            byte[] image = new byte[content.Size];
            DataReader reader = new(content);

            await reader.LoadAsync((uint)content.Size);
            reader.ReadBytes(image);

            return Convert.ToBase64String(image);
        }

        public static string ValidationInt(string rawString, string defaultInt)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string validationString = Strings.StrConv(Regex.Replace(rawString, @"\D", string.Empty), VbStrConv.Narrow);
            string validatedString = validationString != string.Empty ? validationString : defaultInt;

            return validatedString;
        }

        public static void NotificationTest()
        {
            ToastContentBuilder toast = new();
            toast.AddText("テスト通知");
            toast.AddText("JustNotificationのテスト通知です");
            toast.Show();
        }
    }
}
