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
            SuspendLayout();
            // 
            // title_app_label
            // 
            title_app_label.AutoSize = true;
            title_app_label.Font = new Font("Segoe UI", 12F);
            title_app_label.Location = new Point(12, 9);
            title_app_label.Name = "title_app_label";
            title_app_label.Size = new Size(71, 21);
            title_app_label.TabIndex = 0;
            title_app_label.Text = "Program";
            // 
            // ReZe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(title_app_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReZe";
            Text = "ReZe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_app_label;
    }
}
