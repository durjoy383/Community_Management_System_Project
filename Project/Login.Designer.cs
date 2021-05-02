namespace CommunityServiceManagement
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblForgotPasswordLogin = new System.Windows.Forms.Label();
            this.txtBoxPasswordLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtboxNidLogin = new MetroFramework.Controls.MetroTextBox();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogin.Controls.Add(this.lblForgotPasswordLogin);
            this.pnlLogin.Controls.Add(this.txtBoxPasswordLogin);
            this.pnlLogin.Controls.Add(this.txtboxNidLogin);
            this.pnlLogin.Controls.Add(this.btnBackLogin);
            this.pnlLogin.Controls.Add(this.btnLoginLogin);
            this.pnlLogin.Location = new System.Drawing.Point(32, 115);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(490, 611);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblForgotPasswordLogin
            // 
            this.lblForgotPasswordLogin.AutoSize = true;
            this.lblForgotPasswordLogin.Location = new System.Drawing.Point(275, 371);
            this.lblForgotPasswordLogin.Name = "lblForgotPasswordLogin";
            this.lblForgotPasswordLogin.Size = new System.Drawing.Size(122, 17);
            this.lblForgotPasswordLogin.TabIndex = 6;
            this.lblForgotPasswordLogin.Text = "Forgot Password?";
            this.lblForgotPasswordLogin.Click += new System.EventHandler(this.LblForgotPasswordLogin_Click);
            // 
            // txtBoxPasswordLogin
            // 
            // 
            // 
            // 
            this.txtBoxPasswordLogin.CustomButton.Image = null;
            this.txtBoxPasswordLogin.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txtBoxPasswordLogin.CustomButton.Name = "";
            this.txtBoxPasswordLogin.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtBoxPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPasswordLogin.CustomButton.TabIndex = 1;
            this.txtBoxPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPasswordLogin.CustomButton.UseSelectable = true;
            this.txtBoxPasswordLogin.CustomButton.Visible = false;
            this.txtBoxPasswordLogin.Lines = new string[0];
            this.txtBoxPasswordLogin.Location = new System.Drawing.Point(99, 285);
            this.txtBoxPasswordLogin.MaxLength = 32767;
            this.txtBoxPasswordLogin.Name = "txtBoxPasswordLogin";
            this.txtBoxPasswordLogin.PasswordChar = '●';
            this.txtBoxPasswordLogin.PromptText = "Password";
            this.txtBoxPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPasswordLogin.SelectedText = "";
            this.txtBoxPasswordLogin.SelectionLength = 0;
            this.txtBoxPasswordLogin.SelectionStart = 0;
            this.txtBoxPasswordLogin.ShortcutsEnabled = true;
            this.txtBoxPasswordLogin.Size = new System.Drawing.Size(291, 40);
            this.txtBoxPasswordLogin.TabIndex = 5;
            this.txtBoxPasswordLogin.UseSelectable = true;
            this.txtBoxPasswordLogin.UseSystemPasswordChar = true;
            this.txtBoxPasswordLogin.WaterMark = "Password";
            this.txtBoxPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPasswordLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtboxNidLogin
            // 
            // 
            // 
            // 
            this.txtboxNidLogin.CustomButton.Image = null;
            this.txtboxNidLogin.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txtboxNidLogin.CustomButton.Name = "";
            this.txtboxNidLogin.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtboxNidLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxNidLogin.CustomButton.TabIndex = 1;
            this.txtboxNidLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxNidLogin.CustomButton.UseSelectable = true;
            this.txtboxNidLogin.CustomButton.Visible = false;
            this.txtboxNidLogin.Lines = new string[0];
            this.txtboxNidLogin.Location = new System.Drawing.Point(99, 168);
            this.txtboxNidLogin.MaxLength = 32767;
            this.txtboxNidLogin.Name = "txtboxNidLogin";
            this.txtboxNidLogin.PasswordChar = '\0';
            this.txtboxNidLogin.PromptText = "NID/Govt.ID";
            this.txtboxNidLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxNidLogin.SelectedText = "";
            this.txtboxNidLogin.SelectionLength = 0;
            this.txtboxNidLogin.SelectionStart = 0;
            this.txtboxNidLogin.ShortcutsEnabled = true;
            this.txtboxNidLogin.Size = new System.Drawing.Size(291, 40);
            this.txtboxNidLogin.TabIndex = 4;
            this.txtboxNidLogin.UseSelectable = true;
            this.txtboxNidLogin.WaterMark = "NID/Govt.ID";
            this.txtboxNidLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxNidLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.Location = new System.Drawing.Point(275, 459);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(115, 43);
            this.btnBackLogin.TabIndex = 3;
            this.btnBackLogin.Text = "Back";
            this.btnBackLogin.UseVisualStyleBackColor = true;
            this.btnBackLogin.Click += new System.EventHandler(this.BtnBackLogin_Click);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(99, 459);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(115, 43);
            this.btnLoginLogin.TabIndex = 2;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.BtnLoginLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 766);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Button btnBackLogin;
        private MetroFramework.Controls.MetroTextBox txtBoxPasswordLogin;
        private MetroFramework.Controls.MetroTextBox txtboxNidLogin;
        private System.Windows.Forms.Label lblForgotPasswordLogin;
    }
}