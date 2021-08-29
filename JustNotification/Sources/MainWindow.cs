using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using NLog;

namespace JustNotification
{
    public partial class MainWindow : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string[] args = Environment.GetCommandLineArgs();
        private static bool isSteamVR = Array.IndexOf(args, "--steamvr") != -1;
        private static Properties.Settings properties = Properties.Settings.Default;
        private static string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private readonly int[] intervalList = { 500, 1000, 5000 };
        private readonly int[] timeoutList = { 1000, 3000, 5000, 7000, 9000 };

        public MainWindow()
        {
            InitializeComponent();

            // SteamVRからの起動でトレイに格納を有効にしていた場合, 起動時にトレイに格納を有効にしていた場合以外であれば画面を表示する
            if (!(isSteamVR && properties.vr_nogui) && !properties.startup_tray)
            {
                this.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Init();

            logger.Info($"args: {String.Join(" ", args)}");
            logger.Info($"isSteamVR: {isSteamVR}");

            if (properties.is_first_open)
            {
                MessageBox.Show("JustNotificationはXSOverlay上で動作しているため、事前にSteamからXSOverlayを購入・インストールしておく必要があります。\nこのソフト単体では動作しませんのでご注意ください。", "はじめに", MessageBoxButtons.OK);
                properties.is_first_open = false;
                properties.Save();
            }

            label_version.Text = "Version: " + version;
        }

        private void Init()
        {
            UpdateStatus();
            checkBox_autoLaunch.Checked = SteamVR.GetAutoLaunch();
            checkBox_vr_nogui.Checked = properties.vr_nogui;
            checkBox_window.Checked = properties.is_tray;
            checkBox_notification_title.Checked = properties.enable_title;
            textBox_interval.Text = properties.interval.ToString();
            textBox_timeout.Text = properties.timeout.ToString();
            button_vr_unregister.Enabled = SteamVR.GetRegister();
            comboBox_interval.SelectedIndex = Array.IndexOf(intervalList, properties.interval);
            comboBox_timeout.SelectedIndex = Array.IndexOf(timeoutList, properties.timeout);
        }

        private void UpdateStatus()
        {
            bool isAutoLaunch = SteamVR.GetAutoLaunch();

            textBox_status_notifications.Text = Notification.AccessAllowed ? "OK" : "NG";
            textBox_status_notifications.BackColor = Notification.AccessAllowed ? Color.LimeGreen : Color.Tomato;

            textBox_status_startup.Text = isAutoLaunch ? "OK" : "NG";
            textBox_status_startup.BackColor = isAutoLaunch ? Color.LimeGreen : Color.Tomato;
        }

        private void checkBox_autoLaunch_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox_autoLaunch.Checked;

            // SteamVRに登録していなかった場合は登録
            if (!SteamVR.GetRegister() && isChecked)
            {
                bool isSucceedSteamVR = SteamVR.SetRegister(true);
                button_vr_unregister.Enabled = isSucceedSteamVR;

                logger.Trace($"isRegisteredSteamVR: {isSucceedSteamVR}");

                if (!isSucceedSteamVR)
                {
                    MessageBox.Show("SteamVRへの登録に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBox_autoLaunch.Checked = !isChecked;
                    return;
                }
            }

            // メイン処理
            bool isSucceedAutoLaunch = SteamVR.SetAutoLaunch(isChecked);

            // 自動起動処理に失敗した場合
            if (!isSucceedAutoLaunch)
            {
                MessageBox.Show("自動起動の登録/解除に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_autoLaunch.Checked = !isChecked;
                return;
            }

            UpdateStatus();
        }

        private void button_vr_unregister_Click(object sender, EventArgs e)
        {
            bool isSucceedSteamVR = SteamVR.SetRegister(false);

            logger.Trace($"isUnregisteredSteamVR: {isSucceedSteamVR}");

            if (!isSucceedSteamVR)
            {
                MessageBox.Show("登録の解除に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button_vr_unregister.Enabled = false;
            checkBox_autoLaunch.Checked = false;

            UpdateStatus();
        }

        private void checkBox_vr_nogui_CheckedChanged(object sender, EventArgs e)
        {
            properties.vr_nogui = checkBox_vr_nogui.Checked;
            properties.Save();
        }

        private void textBox_interval_Leave(object sender, EventArgs e)
        {
            string validatedString = Utils.ValidationInt(textBox_interval.Text, "1000");
            properties.interval = int.Parse(validatedString);
            properties.Save();

            Init();
        }

        private void textBox_timeout_Leave(object sender, EventArgs e)
        {
            string validatedString = Utils.ValidationInt(textBox_timeout.Text, "1000");
            properties.timeout = int.Parse(validatedString);
            properties.Save();

            Init();
        }

        private void checkBox_notification_title_CheckedChanged(object sender, EventArgs e)
        {
            properties.enable_title = checkBox_notification_title.Checked;
            properties.Save();
        }

        private void checkBox_window_CheckedChanged(object sender, EventArgs e)
        {
            properties.is_tray = checkBox_window.Checked;
            properties.Save();
        }

        private void comboBox_interval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_interval.SelectedIndex == -1) return;

            properties.interval = intervalList[comboBox_interval.SelectedIndex];
            properties.Save();
            Init();
        }

        private void comboBox_timeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_timeout.SelectedIndex == -1) return;

            properties.timeout = timeoutList[comboBox_timeout.SelectedIndex];
            properties.Save();
            Init();
        }

        private void checkBox_startup_tray_CheckedChanged(object sender, EventArgs e)
        {
            properties.startup_tray = checkBox_startup_tray.Checked;
            properties.Save();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(properties.is_tray)
            {
                e.Cancel = true;
                this.Hide();

                if (properties.is_first_tray)
                {
                    Utils.ShowNotification("タスクトレイに格納されました", "JustNotificationを終了するにはタスクトレイにあるアイコンを右クリックしてください");
                    properties.is_first_tray = false;
                    properties.Save();
                }
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) this.Show();
        }

        private void ToolStripMenuItem_ShowWindow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_test_toast_Click(object sender, EventArgs e)
        {
            Utils.ShowNotification("テスト通知", "JustNotificationのテスト通知です");
        }
    }
}
