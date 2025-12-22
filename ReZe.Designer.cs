namespace ReZe
{
    partial class ReZe
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
            title_app_label = new Label();
            list_app = new ListBox();
            btn_add = new Button();
            gb_settings_01 = new GroupBox();
            this.cb_portableRefresh = new ComboBox();
            label_rr = new Label();
            btn_apply = new Button();
            main_menustrip = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            debugWMIToolStripMenuItem = new ToolStripMenuItem();
            list_backend = new ListBox();
            label_backend = new Label();
            label_pwrmode = new Label();
            rb_pwrPortable = new RadioButton();
            rb_pwrPlugged = new RadioButton();
            wmiprocessmonitorToolStripMenuItem = new ToolStripMenuItem();
            getdisplayinfoToolStripMenuItem = new ToolStripMenuItem();
            label_laptopPowerConfig = new Label();
            rb_optionPwrWhisper = new RadioButton();
            rb_pwrOptionDefault = new RadioButton();
            btn_optionAdvancedConfig = new Button();
            lb_fpscap = new Label();
            nud_portableFramerate = new NumericUpDown();
            lb_portable = new Label();
            lb_settingsPlugged = new Label();
            label_rr02 = new Label();
            label_framerate02 = new Label();
            cb_pluggedRefresh = new ComboBox();
            nud_pluggedFramerate = new NumericUpDown();
            gb_settings_01.SuspendLayout();
            main_menustrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_portableFramerate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_pluggedFramerate).BeginInit();
            SuspendLayout();
            // 
            // title_app_label
            // 
            title_app_label.AutoSize = true;
            title_app_label.Font = new Font("Segoe UI", 12F);
            title_app_label.Location = new Point(12, 112);
            title_app_label.Name = "title_app_label";
            title_app_label.Size = new Size(78, 21);
            title_app_label.TabIndex = 0;
            title_app_label.Text = "Programs";
            // 
            // list_app
            // 
            list_app.FormattingEnabled = true;
            list_app.ItemHeight = 15;
            list_app.Location = new Point(12, 139);
            list_app.Name = "list_app";
            list_app.Size = new Size(201, 424);
            list_app.TabIndex = 1;
            list_app.SelectedIndexChanged += list_app_SelectedIndexChanged;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(219, 139);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(164, 42);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Program";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // gb_settings_01
            // 
            gb_settings_01.Controls.Add(nud_pluggedFramerate);
            gb_settings_01.Controls.Add(cb_pluggedRefresh);
            gb_settings_01.Controls.Add(label_framerate02);
            gb_settings_01.Controls.Add(label_rr02);
            gb_settings_01.Controls.Add(lb_settingsPlugged);
            gb_settings_01.Controls.Add(lb_portable);
            gb_settings_01.Controls.Add(nud_portableFramerate);
            gb_settings_01.Controls.Add(lb_fpscap);
            gb_settings_01.Controls.Add(btn_optionAdvancedConfig);
            gb_settings_01.Controls.Add(this.cb_portableRefresh);
            gb_settings_01.Controls.Add(label_rr);
            gb_settings_01.Location = new Point(219, 189);
            gb_settings_01.Name = "gb_settings_01";
            gb_settings_01.Size = new Size(402, 319);
            gb_settings_01.TabIndex = 3;
            gb_settings_01.TabStop = false;
            gb_settings_01.Text = "Settings";
            // 
            // cb_portableRefresh
            // 
            this.cb_portableRefresh.FormattingEnabled = true;
            this.cb_portableRefresh.Location = new Point(6, 64);
            this.cb_portableRefresh.Name = "cb_portableRefresh";
            this.cb_portableRefresh.Size = new Size(158, 23);
            this.cb_portableRefresh.TabIndex = 1;
            // 
            // label_rr
            // 
            label_rr.AutoSize = true;
            label_rr.Location = new Point(6, 46);
            label_rr.Name = "label_rr";
            label_rr.Size = new Size(106, 15);
            label_rr.TabIndex = 0;
            label_rr.Text = "Refresh Rate Mode";
            // 
            // btn_apply
            // 
            btn_apply.Font = new Font("Segoe UI", 12F);
            btn_apply.Location = new Point(457, 514);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(164, 42);
            btn_apply.TabIndex = 4;
            btn_apply.Text = "Save";
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // main_menustrip
            // 
            main_menustrip.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpToolStripMenuItem, debugWMIToolStripMenuItem });
            main_menustrip.Location = new Point(0, 0);
            main_menustrip.Name = "main_menustrip";
            main_menustrip.Size = new Size(842, 24);
            main_menustrip.TabIndex = 6;
            main_menustrip.Text = "menuStrip2";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // debugWMIToolStripMenuItem
            // 
            debugWMIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wmiprocessmonitorToolStripMenuItem, getdisplayinfoToolStripMenuItem });
            debugWMIToolStripMenuItem.Name = "debugWMIToolStripMenuItem";
            debugWMIToolStripMenuItem.Size = new Size(78, 20);
            debugWMIToolStripMenuItem.Text = "Debugging";
            debugWMIToolStripMenuItem.Click += debugWMIToolStripMenuItem_Click;
            // 
            // list_backend
            // 
            list_backend.FormattingEnabled = true;
            list_backend.ItemHeight = 15;
            list_backend.Location = new Point(627, 139);
            list_backend.Name = "list_backend";
            list_backend.Size = new Size(201, 424);
            list_backend.TabIndex = 7;
            // 
            // label_backend
            // 
            label_backend.AutoSize = true;
            label_backend.Font = new Font("Segoe UI", 12F);
            label_backend.Location = new Point(627, 112);
            label_backend.Name = "label_backend";
            label_backend.Size = new Size(144, 21);
            label_backend.TabIndex = 8;
            label_backend.Text = "Active Depedencies";
            // 
            // label_pwrmode
            // 
            label_pwrmode.AutoSize = true;
            label_pwrmode.Location = new Point(12, 33);
            label_pwrmode.Name = "label_pwrmode";
            label_pwrmode.Size = new Size(77, 15);
            label_pwrmode.TabIndex = 9;
            label_pwrmode.Text = "Power Mode:";
            // 
            // rb_pwrPortable
            // 
            rb_pwrPortable.AutoSize = true;
            rb_pwrPortable.Enabled = false;
            rb_pwrPortable.Location = new Point(95, 33);
            rb_pwrPortable.Name = "rb_pwrPortable";
            rb_pwrPortable.Size = new Size(69, 19);
            rb_pwrPortable.TabIndex = 10;
            rb_pwrPortable.TabStop = true;
            rb_pwrPortable.Text = "Portable";
            rb_pwrPortable.UseVisualStyleBackColor = true;
            // 
            // rb_pwrPlugged
            // 
            rb_pwrPlugged.AutoSize = true;
            rb_pwrPlugged.Location = new Point(170, 33);
            rb_pwrPlugged.Name = "rb_pwrPlugged";
            rb_pwrPlugged.Size = new Size(69, 19);
            rb_pwrPlugged.TabIndex = 11;
            rb_pwrPlugged.TabStop = true;
            rb_pwrPlugged.Text = "Plugged";
            rb_pwrPlugged.UseVisualStyleBackColor = true;
            // 
            // wmiprocessmonitorToolStripMenuItem
            // 
            wmiprocessmonitorToolStripMenuItem.Name = "wmiprocessmonitorToolStripMenuItem";
            wmiprocessmonitorToolStripMenuItem.Size = new Size(185, 22);
            wmiprocessmonitorToolStripMenuItem.Text = "wmi_processmonitor";
            // 
            // getdisplayinfoToolStripMenuItem
            // 
            getdisplayinfoToolStripMenuItem.Name = "getdisplayinfoToolStripMenuItem";
            getdisplayinfoToolStripMenuItem.Size = new Size(185, 22);
            getdisplayinfoToolStripMenuItem.Text = "get_displayinfo";
            // 
            // label_laptopPowerConfig
            // 
            label_laptopPowerConfig.AutoSize = true;
            label_laptopPowerConfig.Location = new Point(12, 65);
            label_laptopPowerConfig.Name = "label_laptopPowerConfig";
            label_laptopPowerConfig.Size = new Size(125, 15);
            label_laptopPowerConfig.TabIndex = 12;
            label_laptopPowerConfig.Text = "Current Power Config:";
            // 
            // rb_optionPwrWhisper
            // 
            rb_optionPwrWhisper.AutoSize = true;
            rb_optionPwrWhisper.Location = new Point(143, 65);
            rb_optionPwrWhisper.Name = "rb_optionPwrWhisper";
            rb_optionPwrWhisper.Size = new Size(102, 19);
            rb_optionPwrWhisper.TabIndex = 13;
            rb_optionPwrWhisper.TabStop = true;
            rb_optionPwrWhisper.Text = "Whisper Mode";
            rb_optionPwrWhisper.UseVisualStyleBackColor = true;
            // 
            // rb_pwrOptionDefault
            // 
            rb_pwrOptionDefault.AutoSize = true;
            rb_pwrOptionDefault.Location = new Point(251, 65);
            rb_pwrOptionDefault.Name = "rb_pwrOptionDefault";
            rb_pwrOptionDefault.Size = new Size(63, 19);
            rb_pwrOptionDefault.TabIndex = 14;
            rb_pwrOptionDefault.TabStop = true;
            rb_pwrOptionDefault.Text = "Default";
            rb_pwrOptionDefault.UseVisualStyleBackColor = true;
            // 
            // btn_optionAdvancedConfig
            // 
            btn_optionAdvancedConfig.BackColor = SystemColors.MenuBar;
            btn_optionAdvancedConfig.ForeColor = SystemColors.InfoText;
            btn_optionAdvancedConfig.Location = new Point(6, 281);
            btn_optionAdvancedConfig.Name = "btn_optionAdvancedConfig";
            btn_optionAdvancedConfig.Size = new Size(390, 32);
            btn_optionAdvancedConfig.TabIndex = 15;
            btn_optionAdvancedConfig.Text = "Advanced Config";
            btn_optionAdvancedConfig.UseVisualStyleBackColor = false;
            // 
            // lb_fpscap
            // 
            lb_fpscap.AutoSize = true;
            lb_fpscap.Location = new Point(6, 94);
            lb_fpscap.Name = "lb_fpscap";
            lb_fpscap.Size = new Size(144, 15);
            lb_fpscap.TabIndex = 16;
            lb_fpscap.Text = "Framerate (Requires RTSS)";
            // 
            // nud_portableFramerate
            // 
            nud_portableFramerate.Location = new Point(6, 112);
            nud_portableFramerate.Name = "nud_portableFramerate";
            nud_portableFramerate.Size = new Size(158, 23);
            nud_portableFramerate.TabIndex = 17;
            // 
            // lb_portable
            // 
            lb_portable.AutoSize = true;
            lb_portable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb_portable.Location = new Point(6, 19);
            lb_portable.Name = "lb_portable";
            lb_portable.Size = new Size(75, 19);
            lb_portable.TabIndex = 18;
            lb_portable.Text = "Portable: ";
            // 
            // lb_settingsPlugged
            // 
            lb_settingsPlugged.AutoSize = true;
            lb_settingsPlugged.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb_settingsPlugged.Location = new Point(6, 151);
            lb_settingsPlugged.Name = "lb_settingsPlugged";
            lb_settingsPlugged.Size = new Size(73, 19);
            lb_settingsPlugged.TabIndex = 19;
            lb_settingsPlugged.Text = "Plugged: ";
            // 
            // label_rr02
            // 
            label_rr02.AutoSize = true;
            label_rr02.Location = new Point(6, 170);
            label_rr02.Name = "label_rr02";
            label_rr02.Size = new Size(106, 15);
            label_rr02.TabIndex = 20;
            label_rr02.Text = "Refresh Rate Mode";
            // 
            // label_framerate02
            // 
            label_framerate02.AutoSize = true;
            label_framerate02.Location = new Point(6, 214);
            label_framerate02.Name = "label_framerate02";
            label_framerate02.Size = new Size(144, 15);
            label_framerate02.TabIndex = 21;
            label_framerate02.Text = "Framerate (Requires RTSS)";
            // 
            // cb_pluggedRefresh
            // 
            cb_pluggedRefresh.FormattingEnabled = true;
            cb_pluggedRefresh.Location = new Point(6, 188);
            cb_pluggedRefresh.Name = "cb_pluggedRefresh";
            cb_pluggedRefresh.Size = new Size(158, 23);
            cb_pluggedRefresh.TabIndex = 22;
            // 
            // nud_pluggedFramerate
            // 
            nud_pluggedFramerate.Location = new Point(6, 232);
            nud_pluggedFramerate.Name = "nud_pluggedFramerate";
            nud_pluggedFramerate.Size = new Size(158, 23);
            nud_pluggedFramerate.TabIndex = 23;
            // 
            // ReZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(842, 568);
            Controls.Add(rb_pwrOptionDefault);
            Controls.Add(rb_optionPwrWhisper);
            Controls.Add(label_laptopPowerConfig);
            Controls.Add(rb_pwrPlugged);
            Controls.Add(rb_pwrPortable);
            Controls.Add(label_pwrmode);
            Controls.Add(label_backend);
            Controls.Add(list_backend);
            Controls.Add(btn_apply);
            Controls.Add(gb_settings_01);
            Controls.Add(btn_add);
            Controls.Add(list_app);
            Controls.Add(title_app_label);
            Controls.Add(main_menustrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReZe";
            Text = "ReZe - Kobayashi's Gaming Tool ALPHA";
            gb_settings_01.ResumeLayout(false);
            gb_settings_01.PerformLayout();
            main_menustrip.ResumeLayout(false);
            main_menustrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_portableFramerate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_pluggedFramerate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_app_label;
        private ListBox list_app;
        private Button btn_add;
        private GroupBox gb_settings_01;
        private Button btn_apply;
        private MenuStrip main_menustrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListBox list_backend;
        private Label label_backend;
        private ToolStripMenuItem debugWMIToolStripMenuItem;
        private ComboBox cb_rr;
        private Label label_rr;
        private Label label_pwrmode;
        private RadioButton rb_pwrPortable;
        private RadioButton rb_pwrPlugged;
        private ToolStripMenuItem wmiprocessmonitorToolStripMenuItem;
        private ToolStripMenuItem getdisplayinfoToolStripMenuItem;
        private Button btn_optionAdvancedConfig;
        private Label label_laptopPowerConfig;
        private RadioButton rb_optionPwrWhisper;
        private RadioButton rb_pwrOptionDefault;
        private NumericUpDown nud_portableFramerate;
        private Label lb_fpscap;
        private Label lb_settingsPlugged;
        private Label lb_portable;
        private NumericUpDown nud_pluggedFramerate;
        private ComboBox cb_pluggedRefresh;
        private Label label_framerate02;
        private Label label_rr02;
    }
}
