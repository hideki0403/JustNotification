using System;
using System.Windows.Forms;

namespace JustNotification
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize
            Init();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new MainWindow();
            Application.Run();
        }

        static void Init()
        {
            Notification.Init();
            SteamVR.Init();
        }
    }
}
