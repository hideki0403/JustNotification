using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Valve.VR;

namespace JustNotification
{
    class SteamVR
    {
        private static EVRInitError EVRErr;
        private static CVRSystem OVR;
        private static CVRApplications OVRApp;

        private static string path = Path.GetFullPath("./Resources/JustNotification.vrmanifest");
        private static string pchkey = "JustNotification";

        public static void Init()
        {
            EVRErr = new();
            OVR = OpenVR.Init(ref EVRErr, EVRApplicationType.VRApplication_Utility);

            if(EVRErr != EVRInitError.None)
            {
                MessageBox.Show($"SteamVRでエラーが発生しています: {EVRErr}\nSteamVRを一度終了してから再度お試しください。", "SteamVRエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            OVRApp = OpenVR.Applications;
        }

        public static bool SetRegister(bool isEnable)
        {

            EVRApplicationError EVRError;

            if (isEnable)
            {
                EVRError = OVRApp.AddApplicationManifest(path, false);
            }
            else
            {
                EVRError = OVRApp.RemoveApplicationManifest(path);
            }

            bool isSuccess = EVRError == EVRApplicationError.None || EVRError == EVRApplicationError.UnknownApplication;

            if (!isSuccess) Debug.Print(EVRError.ToString());

            return isSuccess;
        }

        public static bool GetRegister()
        {
            return OVRApp.IsApplicationInstalled(pchkey);
        }

        public static bool SetAutoLaunch(bool isEnable)
        {
            EVRApplicationError EVRError = OVRApp.SetApplicationAutoLaunch(pchkey, isEnable);
            bool isSuccess = EVRError == EVRApplicationError.None || EVRError == EVRApplicationError.UnknownApplication;

            if (!isSuccess) Debug.Print(EVRError.ToString());

            return isSuccess;
        }

        public static bool GetAutoLaunch()
        {
            return OVRApp.GetApplicationAutoLaunch(pchkey);
        }
    }
}
