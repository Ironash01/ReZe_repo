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
            current_refresh = new Label();
            cb_rr = new ComboBox();
            label_rr = new Label();
            btn_apply = new Button();
            main_menustrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            debugWMIToolStripMenuItem = new ToolStripMenuItem();
            list_backend = new ListBox();
            label_backend = new Label();
            label_pwrmode = new Label();
            rb_pwrPortable = new RadioButton();
            rb_pwrPlugged = new RadioButton();
            gb_settings_01.SuspendLayout();
            main_menustrip.SuspendLayout();
            SuspendLayout();
            // 
            // title_app_label
            // 
            title_app_label.AutoSize = true;
            title_app_label.Font = new Font("Segoe UI", 12F);
            title_app_label.Location = new Point(12, 65);
            title_app_label.Name = "title_app_label";
            title_app_label.Size = new Size(78, 21);
            title_app_label.TabIndex = 0;
            title_app_label.Text = "Programs";
            // 
            // list_app
            // 
            list_app.FormattingEnabled = true;
            list_app.ItemHeight = 15;
            list_app.Location = new Point(12, 89);
            list_app.Name = "list_app";
            list_app.Size = new Size(201, 394);
            list_app.TabIndex = 1;
            list_app.SelectedIndexChanged += list_app_SelectedIndexChanged;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(219, 91);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(164, 42);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Program";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // gb_settings_01
            // 
            gb_settings_01.Controls.Add(current_refresh);
            gb_settings_01.Controls.Add(cb_rr);
            gb_settings_01.Controls.Add(label_rr);
            gb_settings_01.Location = new Point(219, 139);
            gb_settings_01.Name = "gb_settings_01";
            gb_settings_01.Size = new Size(402, 296);
            gb_settings_01.TabIndex = 3;
            gb_settings_01.TabStop = false;
            gb_settings_01.Text = "Settings";
            // 
            // current_refresh
            // 
            current_refresh.AutoSize = true;
            current_refresh.Location = new Point(170, 40);
            current_refresh.Name = "current_refresh";
            current_refresh.Size = new Size(50, 15);
            current_refresh.TabIndex = 2;
            current_refresh.Text = "Current:";
            current_refresh.Click += current_refresh_Click;
            // 
            // cb_rr
            // 
            cb_rr.FormattingEnabled = true;
            cb_rr.Location = new Point(6, 37);
            cb_rr.Name = "cb_rr";
            cb_rr.Size = new Size(158, 23);
            cb_rr.TabIndex = 1;
            // 
            // label_rr
            // 
            label_rr.AutoSize = true;
            label_rr.Location = new Point(6, 19);
            label_rr.Name = "label_rr";
            label_rr.Size = new Size(106, 15);
            label_rr.TabIndex = 0;
            label_rr.Text = "Refresh Rate Mode";
            // 
            // btn_apply
            // 
            btn_apply.Font = new Font("Segoe UI", 12F);
            btn_apply.Location = new Point(457, 441);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(164, 42);
            btn_apply.TabIndex = 4;
            btn_apply.Text = "Save";
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // main_menustrip
            // 
            main_menustrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem, helpToolStripMenuItem, debugWMIToolStripMenuItem });
            main_menustrip.Location = new Point(0, 0);
            main_menustrip.Name = "main_menustrip";
            main_menustrip.Size = new Size(854, 24);
            main_menustrip.TabIndex = 6;
            main_menustrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
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
            debugWMIToolStripMenuItem.Name = "debugWMIToolStripMenuItem";
            debugWMIToolStripMenuItem.Size = new Size(82, 20);
            debugWMIToolStripMenuItem.Text = "Debug WMI";
            debugWMIToolStripMenuItem.Click += debugWMIToolStripMenuItem_Click;
            // 
            // list_backend
            // 
            list_backend.FormattingEnabled = true;
            list_backend.ItemHeight = 15;
            list_backend.Location = new Point(627, 89);
            list_backend.Name = "list_backend";
            list_backend.Size = new Size(201, 394);
            list_backend.TabIndex = 7;
            // 
            // label_backend
            // 
            label_backend.AutoSize = true;
            label_backend.Font = new Font("Segoe UI", 12F);
            label_backend.Location = new Point(627, 65);
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
            // ReZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 540);
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
            Text = "ReZe - Kobayashi's Gaming Tool";
            gb_settings_01.ResumeLayout(false);
            gb_settings_01.PerformLayout();
            main_menustrip.ResumeLayout(false);
            main_menustrip.PerformLayout();
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
        private Label current_refresh;
    }
}
