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
        public static string ValidationInt(string rawString, string defaultInt)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string validationString = Strings.StrConv(Regex.Replace(rawString, @"\D", string.Empty), VbStrConv.Narrow);
            string validatedString = validationString != string.Empty ? validationString : defaultInt;

            return validatedString;
        }

        public static void ShowNotification(string title, string text)
        {
            ToastContentBuilder toast = new();
            toast.AddText(title);
            toast.AddText(text);
            toast.Show();
        }
    }
}
