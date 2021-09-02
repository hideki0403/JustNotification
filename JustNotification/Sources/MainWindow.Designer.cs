
namespace JustNotification
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_ShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.checkBox_window = new System.Windows.Forms.CheckBox();
            this.checkBox_startup_tray = new System.Windows.Forms.CheckBox();
            this.groupBox_notification = new System.Windows.Forms.GroupBox();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.label_interval = new System.Windows.Forms.Label();
            this.label_interval_ms = new System.Windows.Forms.Label();
            this.label_ms_info = new System.Windows.Forms.Label();
            this.checkBox_notification_title = new System.Windows.Forms.CheckBox();
            this.textBox_timeout = new System.Windows.Forms.TextBox();
            this.label_timeout = new System.Windows.Forms.Label();
            this.label_timeout_ms = new System.Windows.Forms.Label();
            this.groupBox_steamvr = new System.Windows.Forms.GroupBox();
            this.checkBox_vr_nogui = new System.Windows.Forms.CheckBox();
            this.button_vr_unregister = new System.Windows.Forms.Button();
            this.label_vr_unregister = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_main_settings = new System.Windows.Forms.GroupBox();
            this.label_main_info_interval = new System.Windows.Forms.Label();
            this.checkBox_autoLaunch = new System.Windows.Forms.CheckBox();
            this.comboBox_interval = new System.Windows.Forms.ComboBox();
            this.button_test_toast = new System.Windows.Forms.Button();
            this.label_main_info_timeout = new System.Windows.Forms.Label();
            this.comboBox_timeout = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_xs = new System.Windows.Forms.RadioButton();
            this.label_send_soft = new System.Windows.Forms.Label();
            this.radioButton_jn = new System.Windows.Forms.RadioButton();
            this.groupBox_main_status = new System.Windows.Forms.GroupBox();
            this.textBox_status_startup = new System.Windows.Forms.TextBox();
            this.label_status_notifications = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_status_notifications = new System.Windows.Forms.TextBox();
            this.label_info_notification = new System.Windows.Forms.Label();
            this.label_info_steamvr = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.contextMenuStrip_tray.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_notification.SuspendLayout();
            this.groupBox_steamvr.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_main_settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_main_status.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_tray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "JustNotification";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip_tray
            // 
            this.contextMenuStrip_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ShowWindow,
            this.ToolStripMenuItem_exit});
            this.contextMenuStrip_tray.Name = "contextMenuStrip_tray";
            this.contextMenuStrip_tray.Size = new System.Drawing.Size(150, 48);
            // 
            // ToolStripMenuItem_ShowWindow
            // 
            this.ToolStripMenuItem_ShowWindow.Name = "ToolStripMenuItem_ShowWindow";
            this.ToolStripMenuItem_ShowWindow.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_ShowWindow.Text = "ウィンドウを表示";
            this.ToolStripMenuItem_ShowWindow.Click += new System.EventHandler(this.ToolStripMenuItem_ShowWindow_Click);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItem_exit.Text = "ソフトを終了";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tableLayoutPanel2);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(621, 315);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "詳細設定";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_steamvr, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_notification, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_settings, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(615, 309);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.checkBox_startup_tray);
            this.groupBox_settings.Controls.Add(this.checkBox_window);
            this.groupBox_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_settings.Location = new System.Drawing.Point(310, 3);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(302, 148);
            this.groupBox_settings.TabIndex = 5;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "全般";
            // 
            // checkBox_window
            // 
            this.checkBox_window.AutoSize = true;
            this.checkBox_window.Location = new System.Drawing.Point(16, 22);
            this.checkBox_window.Name = "checkBox_window";
            this.checkBox_window.Size = new System.Drawing.Size(207, 19);
            this.checkBox_window.TabIndex = 0;
            this.checkBox_window.Text = "ウィンドウを閉じた際はトレイに格納する";
            this.checkBox_window.UseVisualStyleBackColor = true;
            this.checkBox_window.CheckedChanged += new System.EventHandler(this.checkBox_window_CheckedChanged);
            // 
            // checkBox_startup_tray
            // 
            this.checkBox_startup_tray.AutoSize = true;
            this.checkBox_startup_tray.Location = new System.Drawing.Point(16, 47);
            this.checkBox_startup_tray.Name = "checkBox_startup_tray";
            this.checkBox_startup_tray.Size = new System.Drawing.Size(130, 19);
            this.checkBox_startup_tray.TabIndex = 1;
            this.checkBox_startup_tray.Text = "起動時にトレイに格納";
            this.checkBox_startup_tray.UseVisualStyleBackColor = true;
            this.checkBox_startup_tray.CheckedChanged += new System.EventHandler(this.checkBox_startup_tray_CheckedChanged);
            // 
            // groupBox_notification
            // 
            this.groupBox_notification.Controls.Add(this.label_timeout_ms);
            this.groupBox_notification.Controls.Add(this.label_timeout);
            this.groupBox_notification.Controls.Add(this.textBox_timeout);
            this.groupBox_notification.Controls.Add(this.checkBox_notification_title);
            this.groupBox_notification.Controls.Add(this.label_ms_info);
            this.groupBox_notification.Controls.Add(this.label_interval_ms);
            this.groupBox_notification.Controls.Add(this.label_interval);
            this.groupBox_notification.Controls.Add(this.textBox_interval);
            this.groupBox_notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_notification.Location = new System.Drawing.Point(3, 157);
            this.groupBox_notification.Name = "groupBox_notification";
            this.groupBox_notification.Size = new System.Drawing.Size(301, 149);
            this.groupBox_notification.TabIndex = 4;
            this.groupBox_notification.TabStop = false;
            this.groupBox_notification.Text = "通知";
            // 
            // textBox_interval
            // 
            this.textBox_interval.Location = new System.Drawing.Point(129, 51);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(100, 23);
            this.textBox_interval.TabIndex = 0;
            this.textBox_interval.Leave += new System.EventHandler(this.textBox_interval_Leave);
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(13, 54);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(110, 15);
            this.label_interval.TabIndex = 1;
            this.label_interval.Text = "通知を取得する間隔:";
            this.label_interval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_interval_ms
            // 
            this.label_interval_ms.AutoSize = true;
            this.label_interval_ms.Location = new System.Drawing.Point(235, 54);
            this.label_interval_ms.Name = "label_interval_ms";
            this.label_interval_ms.Size = new System.Drawing.Size(34, 15);
            this.label_interval_ms.TabIndex = 2;
            this.label_interval_ms.Text = "ミリ秒";
            this.label_interval_ms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ms_info
            // 
            this.label_ms_info.AutoSize = true;
            this.label_ms_info.Location = new System.Drawing.Point(13, 112);
            this.label_ms_info.Name = "label_ms_info";
            this.label_ms_info.Size = new System.Drawing.Size(92, 15);
            this.label_ms_info.TabIndex = 3;
            this.label_ms_info.Text = "(1秒=1000ミリ秒)";
            // 
            // checkBox_notification_title
            // 
            this.checkBox_notification_title.AutoSize = true;
            this.checkBox_notification_title.Location = new System.Drawing.Point(13, 22);
            this.checkBox_notification_title.Name = "checkBox_notification_title";
            this.checkBox_notification_title.Size = new System.Drawing.Size(172, 19);
            this.checkBox_notification_title.TabIndex = 4;
            this.checkBox_notification_title.Text = "通知タイトルにソフト名を含める";
            this.checkBox_notification_title.UseVisualStyleBackColor = true;
            this.checkBox_notification_title.CheckedChanged += new System.EventHandler(this.checkBox_notification_title_CheckedChanged);
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.Location = new System.Drawing.Point(129, 80);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(100, 23);
            this.textBox_timeout.TabIndex = 5;
            this.textBox_timeout.Leave += new System.EventHandler(this.textBox_timeout_Leave);
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(13, 83);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(110, 15);
            this.label_timeout.TabIndex = 6;
            this.label_timeout.Text = "通知を表示する秒数:";
            this.label_timeout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_timeout_ms
            // 
            this.label_timeout_ms.AutoSize = true;
            this.label_timeout_ms.Location = new System.Drawing.Point(235, 83);
            this.label_timeout_ms.Name = "label_timeout_ms";
            this.label_timeout_ms.Size = new System.Drawing.Size(34, 15);
            this.label_timeout_ms.TabIndex = 7;
            this.label_timeout_ms.Text = "ミリ秒";
            this.label_timeout_ms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_steamvr
            // 
            this.groupBox_steamvr.Controls.Add(this.label_vr_unregister);
            this.groupBox_steamvr.Controls.Add(this.button_vr_unregister);
            this.groupBox_steamvr.Controls.Add(this.checkBox_vr_nogui);
            this.groupBox_steamvr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_steamvr.Location = new System.Drawing.Point(3, 3);
            this.groupBox_steamvr.Name = "groupBox_steamvr";
            this.groupBox_steamvr.Size = new System.Drawing.Size(301, 148);
            this.groupBox_steamvr.TabIndex = 3;
            this.groupBox_steamvr.TabStop = false;
            this.groupBox_steamvr.Text = "SteamVR";
            // 
            // checkBox_vr_nogui
            // 
            this.checkBox_vr_nogui.AutoSize = true;
            this.checkBox_vr_nogui.Location = new System.Drawing.Point(13, 22);
            this.checkBox_vr_nogui.Name = "checkBox_vr_nogui";
            this.checkBox_vr_nogui.Size = new System.Drawing.Size(221, 19);
            this.checkBox_vr_nogui.TabIndex = 2;
            this.checkBox_vr_nogui.Text = "自動起動の場合はウィンドウを表示しない";
            this.checkBox_vr_nogui.UseVisualStyleBackColor = true;
            this.checkBox_vr_nogui.CheckedChanged += new System.EventHandler(this.checkBox_vr_nogui_CheckedChanged);
            // 
            // button_vr_unregister
            // 
            this.button_vr_unregister.AutoSize = true;
            this.button_vr_unregister.Location = new System.Drawing.Point(13, 57);
            this.button_vr_unregister.Name = "button_vr_unregister";
            this.button_vr_unregister.Size = new System.Drawing.Size(165, 27);
            this.button_vr_unregister.TabIndex = 3;
            this.button_vr_unregister.Text = "スタートアップから削除";
            this.button_vr_unregister.UseVisualStyleBackColor = true;
            this.button_vr_unregister.Click += new System.EventHandler(this.button_vr_unregister_Click);
            // 
            // label_vr_unregister
            // 
            this.label_vr_unregister.AutoEllipsis = true;
            this.label_vr_unregister.AutoSize = true;
            this.label_vr_unregister.ForeColor = System.Drawing.Color.Black;
            this.label_vr_unregister.Location = new System.Drawing.Point(38, 97);
            this.label_vr_unregister.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label_vr_unregister.Name = "label_vr_unregister";
            this.label_vr_unregister.Size = new System.Drawing.Size(0, 15);
            this.label_vr_unregister.TabIndex = 4;
            this.label_vr_unregister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tableLayoutPanel1);
            this.tabMain.Location = new System.Drawing.Point(4, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(621, 315);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "メイン";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_main_status, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_main_settings, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 309);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox_main_settings
            // 
            this.groupBox_main_settings.Controls.Add(this.panel1);
            this.groupBox_main_settings.Controls.Add(this.comboBox_timeout);
            this.groupBox_main_settings.Controls.Add(this.label_main_info_timeout);
            this.groupBox_main_settings.Controls.Add(this.button_test_toast);
            this.groupBox_main_settings.Controls.Add(this.comboBox_interval);
            this.groupBox_main_settings.Controls.Add(this.checkBox_autoLaunch);
            this.groupBox_main_settings.Controls.Add(this.label_main_info_interval);
            this.groupBox_main_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main_settings.Location = new System.Drawing.Point(3, 103);
            this.groupBox_main_settings.Name = "groupBox_main_settings";
            this.groupBox_main_settings.Size = new System.Drawing.Size(609, 203);
            this.groupBox_main_settings.TabIndex = 1;
            this.groupBox_main_settings.TabStop = false;
            this.groupBox_main_settings.Text = "かんたん設定";
            // 
            // label_main_info_interval
            // 
            this.label_main_info_interval.AutoSize = true;
            this.label_main_info_interval.Location = new System.Drawing.Point(16, 67);
            this.label_main_info_interval.Name = "label_main_info_interval";
            this.label_main_info_interval.Size = new System.Drawing.Size(107, 15);
            this.label_main_info_interval.TabIndex = 1;
            this.label_main_info_interval.Text = "通知を取得する間隔";
            // 
            // checkBox_autoLaunch
            // 
            this.checkBox_autoLaunch.AutoSize = true;
            this.checkBox_autoLaunch.Location = new System.Drawing.Point(16, 31);
            this.checkBox_autoLaunch.Name = "checkBox_autoLaunch";
            this.checkBox_autoLaunch.Size = new System.Drawing.Size(227, 19);
            this.checkBox_autoLaunch.TabIndex = 2;
            this.checkBox_autoLaunch.Text = "SteamVRが起動したらこのソフトも起動する";
            this.checkBox_autoLaunch.UseVisualStyleBackColor = true;
            this.checkBox_autoLaunch.CheckedChanged += new System.EventHandler(this.checkBox_autoLaunch_CheckedChanged);
            // 
            // comboBox_interval
            // 
            this.comboBox_interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_interval.FormattingEnabled = true;
            this.comboBox_interval.Items.AddRange(new object[] {
            "短い (0.5秒ごと)",
            "普通 (1秒ごと)",
            "長い (5秒ごと)"});
            this.comboBox_interval.Location = new System.Drawing.Point(129, 64);
            this.comboBox_interval.Name = "comboBox_interval";
            this.comboBox_interval.Size = new System.Drawing.Size(121, 23);
            this.comboBox_interval.TabIndex = 3;
            this.comboBox_interval.SelectedIndexChanged += new System.EventHandler(this.comboBox_interval_SelectedIndexChanged);
            // 
            // button_test_toast
            // 
            this.button_test_toast.Location = new System.Drawing.Point(388, 82);
            this.button_test_toast.Name = "button_test_toast";
            this.button_test_toast.Size = new System.Drawing.Size(154, 62);
            this.button_test_toast.TabIndex = 4;
            this.button_test_toast.Text = "テスト通知を送信する";
            this.button_test_toast.UseVisualStyleBackColor = true;
            this.button_test_toast.Click += new System.EventHandler(this.button_test_toast_Click);
            // 
            // label_main_info_timeout
            // 
            this.label_main_info_timeout.AutoSize = true;
            this.label_main_info_timeout.Location = new System.Drawing.Point(16, 106);
            this.label_main_info_timeout.Name = "label_main_info_timeout";
            this.label_main_info_timeout.Size = new System.Drawing.Size(103, 15);
            this.label_main_info_timeout.TabIndex = 5;
            this.label_main_info_timeout.Text = "通知を表示する長さ";
            // 
            // comboBox_timeout
            // 
            this.comboBox_timeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_timeout.FormattingEnabled = true;
            this.comboBox_timeout.Items.AddRange(new object[] {
            "とても短い (1秒)",
            "短い (3秒)",
            "普通 (5秒)",
            "長い (7秒)",
            "とても長い (9秒)"});
            this.comboBox_timeout.Location = new System.Drawing.Point(129, 103);
            this.comboBox_timeout.Name = "comboBox_timeout";
            this.comboBox_timeout.Size = new System.Drawing.Size(121, 23);
            this.comboBox_timeout.TabIndex = 6;
            this.comboBox_timeout.SelectedIndexChanged += new System.EventHandler(this.comboBox_timeout_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_jn);
            this.panel1.Controls.Add(this.label_send_soft);
            this.panel1.Controls.Add(this.radioButton_xs);
            this.panel1.Location = new System.Drawing.Point(16, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 60);
            this.panel1.TabIndex = 7;
            // 
            // radioButton_xs
            // 
            this.radioButton_xs.AutoSize = true;
            this.radioButton_xs.Location = new System.Drawing.Point(113, 9);
            this.radioButton_xs.Name = "radioButton_xs";
            this.radioButton_xs.Size = new System.Drawing.Size(78, 19);
            this.radioButton_xs.TabIndex = 0;
            this.radioButton_xs.TabStop = true;
            this.radioButton_xs.Text = "XSOverlay";
            this.radioButton_xs.UseVisualStyleBackColor = true;
            this.radioButton_xs.CheckedChanged += new System.EventHandler(this.radioButton_xs_CheckedChanged);
            // 
            // label_send_soft
            // 
            this.label_send_soft.AutoSize = true;
            this.label_send_soft.Location = new System.Drawing.Point(0, 11);
            this.label_send_soft.Name = "label_send_soft";
            this.label_send_soft.Size = new System.Drawing.Size(108, 15);
            this.label_send_soft.TabIndex = 1;
            this.label_send_soft.Text = "通知を受信するソフト";
            // 
            // radioButton_jn
            // 
            this.radioButton_jn.AutoSize = true;
            this.radioButton_jn.Location = new System.Drawing.Point(113, 34);
            this.radioButton_jn.Name = "radioButton_jn";
            this.radioButton_jn.Size = new System.Drawing.Size(151, 19);
            this.radioButton_jn.TabIndex = 2;
            this.radioButton_jn.TabStop = true;
            this.radioButton_jn.Text = "JustNotification Overlay";
            this.radioButton_jn.UseVisualStyleBackColor = true;
            // 
            // groupBox_main_status
            // 
            this.groupBox_main_status.Controls.Add(this.label_info_steamvr);
            this.groupBox_main_status.Controls.Add(this.label_info_notification);
            this.groupBox_main_status.Controls.Add(this.textBox_status_notifications);
            this.groupBox_main_status.Controls.Add(this.label1);
            this.groupBox_main_status.Controls.Add(this.label_status_notifications);
            this.groupBox_main_status.Controls.Add(this.textBox_status_startup);
            this.groupBox_main_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main_status.Location = new System.Drawing.Point(3, 3);
            this.groupBox_main_status.Name = "groupBox_main_status";
            this.groupBox_main_status.Size = new System.Drawing.Size(609, 94);
            this.groupBox_main_status.TabIndex = 0;
            this.groupBox_main_status.TabStop = false;
            this.groupBox_main_status.Text = "状態";
            // 
            // textBox_status_startup
            // 
            this.textBox_status_startup.ForeColor = System.Drawing.Color.White;
            this.textBox_status_startup.Location = new System.Drawing.Point(90, 55);
            this.textBox_status_startup.Name = "textBox_status_startup";
            this.textBox_status_startup.ReadOnly = true;
            this.textBox_status_startup.Size = new System.Drawing.Size(61, 23);
            this.textBox_status_startup.TabIndex = 2;
            this.textBox_status_startup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_status_notifications
            // 
            this.label_status_notifications.AutoSize = true;
            this.label_status_notifications.Location = new System.Drawing.Point(16, 29);
            this.label_status_notifications.Name = "label_status_notifications";
            this.label_status_notifications.Size = new System.Drawing.Size(68, 15);
            this.label_status_notifications.TabIndex = 1;
            this.label_status_notifications.Text = "通知の受信:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "自動起動:";
            // 
            // textBox_status_notifications
            // 
            this.textBox_status_notifications.ForeColor = System.Drawing.Color.White;
            this.textBox_status_notifications.Location = new System.Drawing.Point(90, 26);
            this.textBox_status_notifications.Name = "textBox_status_notifications";
            this.textBox_status_notifications.ReadOnly = true;
            this.textBox_status_notifications.Size = new System.Drawing.Size(61, 23);
            this.textBox_status_notifications.TabIndex = 0;
            this.textBox_status_notifications.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_info_notification
            // 
            this.label_info_notification.AutoSize = true;
            this.label_info_notification.Location = new System.Drawing.Point(166, 29);
            this.label_info_notification.Name = "label_info_notification";
            this.label_info_notification.Size = new System.Drawing.Size(332, 15);
            this.label_info_notification.TabIndex = 4;
            this.label_info_notification.Text = "(NGの場合はWindowsの設定から「通知の取得」を許可してください)";
            // 
            // label_info_steamvr
            // 
            this.label_info_steamvr.AutoSize = true;
            this.label_info_steamvr.Location = new System.Drawing.Point(166, 58);
            this.label_info_steamvr.Name = "label_info_steamvr";
            this.label_info_steamvr.Size = new System.Drawing.Size(296, 15);
            this.label_info_steamvr.TabIndex = 5;
            this.label_info_steamvr.Text = "(下のかんたん設定から自動起動を切り替えることが出来ます)";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabMain);
            this.tab.Controls.Add(this.tabSettings);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(629, 343);
            this.tab.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 343);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "JustNotification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStrip_tray.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_notification.ResumeLayout(false);
            this.groupBox_notification.PerformLayout();
            this.groupBox_steamvr.ResumeLayout(false);
            this.groupBox_steamvr.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_main_settings.ResumeLayout(false);
            this.groupBox_main_settings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_main_status.ResumeLayout(false);
            this.groupBox_main_status.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_tray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ShowWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox_steamvr;
        private System.Windows.Forms.Label label_vr_unregister;
        private System.Windows.Forms.Button button_vr_unregister;
        private System.Windows.Forms.CheckBox checkBox_vr_nogui;
        private System.Windows.Forms.GroupBox groupBox_notification;
        private System.Windows.Forms.Label label_timeout_ms;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.TextBox textBox_timeout;
        private System.Windows.Forms.CheckBox checkBox_notification_title;
        private System.Windows.Forms.Label label_ms_info;
        private System.Windows.Forms.Label label_interval_ms;
        private System.Windows.Forms.Label label_interval;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.CheckBox checkBox_startup_tray;
        private System.Windows.Forms.CheckBox checkBox_window;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_main_status;
        private System.Windows.Forms.Label label_info_steamvr;
        private System.Windows.Forms.Label label_info_notification;
        private System.Windows.Forms.TextBox textBox_status_notifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_status_notifications;
        private System.Windows.Forms.TextBox textBox_status_startup;
        private System.Windows.Forms.GroupBox groupBox_main_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_jn;
        private System.Windows.Forms.Label label_send_soft;
        private System.Windows.Forms.RadioButton radioButton_xs;
        private System.Windows.Forms.ComboBox comboBox_timeout;
        private System.Windows.Forms.Label label_main_info_timeout;
        private System.Windows.Forms.Button button_test_toast;
        private System.Windows.Forms.ComboBox comboBox_interval;
        private System.Windows.Forms.CheckBox checkBox_autoLaunch;
        private System.Windows.Forms.Label label_main_info_interval;
        private System.Windows.Forms.TabControl tab;
    }
}

