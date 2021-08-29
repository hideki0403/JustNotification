using System;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Foundation;
using Windows.Storage.Streams;

namespace JustNotification
{
    class Utils
    {
        public static async Task<string> GetLogoAsync(UserNotification app)
        {
            RandomAccessStreamReference stream = app.AppInfo.DisplayInfo.GetLogo(new Size(64, 64));

            if (stream == null) return "";

            IRandomAccessStreamWithContentType content = await stream.OpenReadAsync();

            byte[] image = new byte[content.Size];
            DataReader reader = new DataReader(content);

            await reader.LoadAsync((uint)content.Size);
            reader.ReadBytes(image);

            return Convert.ToBase64String(image);
        }
    }
}
