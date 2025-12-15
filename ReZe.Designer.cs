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
            btn_apply = new Button();
            main_menustrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            main_menustrip.SuspendLayout();
            SuspendLayout();
            // 
            // title_app_label
            // 
            title_app_label.AutoSize = true;
            title_app_label.Font = new Font("Segoe UI", 12F);
            title_app_label.Location = new Point(12, 33);
            title_app_label.Name = "title_app_label";
            title_app_label.Size = new Size(78, 21);
            title_app_label.TabIndex = 0;
            title_app_label.Text = "Programs";
            // 
            // list_app
            // 
            list_app.FormattingEnabled = true;
            list_app.ItemHeight = 15;
            list_app.Location = new Point(12, 57);
            list_app.Name = "list_app";
            list_app.Size = new Size(201, 394);
            list_app.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(219, 57);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(164, 42);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Program";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // gb_settings_01
            // 
            gb_settings_01.Location = new Point(219, 105);
            gb_settings_01.Name = "gb_settings_01";
            gb_settings_01.Size = new Size(402, 296);
            gb_settings_01.TabIndex = 3;
            gb_settings_01.TabStop = false;
            gb_settings_01.Text = "Settings";
            // 
            // btn_apply
            // 
            btn_apply.Font = new Font("Segoe UI", 12F);
            btn_apply.Location = new Point(457, 407);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(164, 42);
            btn_apply.TabIndex = 4;
            btn_apply.Text = "Apply Settings";
            btn_apply.UseVisualStyleBackColor = true;
            // 
            // main_menustrip
            // 
            main_menustrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem, helpToolStripMenuItem });
            main_menustrip.Location = new Point(0, 0);
            main_menustrip.Name = "main_menustrip";
            main_menustrip.Size = new Size(636, 24);
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
            // ReZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 457);
            Controls.Add(btn_apply);
            Controls.Add(gb_settings_01);
            Controls.Add(btn_add);
            Controls.Add(list_app);
            Controls.Add(title_app_label);
            Controls.Add(main_menustrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReZe";
            Text = "ReZe - Kobayashi's Gaming Tool";
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
    }
}
