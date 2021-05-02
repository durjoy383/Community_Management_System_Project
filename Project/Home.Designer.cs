namespace CommunityServiceManagement
{
    partial class Home
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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnExitHome = new System.Windows.Forms.Button();
            this.btnRegistrationHome = new System.Windows.Forms.Button();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHome.Controls.Add(this.btnExitHome);
            this.pnlHome.Controls.Add(this.btnRegistrationHome);
            this.pnlHome.Controls.Add(this.btnLoginHome);
            this.pnlHome.Location = new System.Drawing.Point(24, 64);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(472, 677);
            this.pnlHome.TabIndex = 0;
            // 
            // btnExitHome
            // 
            this.btnExitHome.Location = new System.Drawing.Point(176, 460);
            this.btnExitHome.Name = "btnExitHome";
            this.btnExitHome.Size = new System.Drawing.Size(125, 40);
            this.btnExitHome.TabIndex = 3;
            this.btnExitHome.Text = "Exit";
            this.btnExitHome.UseVisualStyleBackColor = true;
            this.btnExitHome.Click += new System.EventHandler(this.BtnExitHome_Click);
            // 
            // btnRegistrationHome
            // 
            this.btnRegistrationHome.Location = new System.Drawing.Point(277, 255);
            this.btnRegistrationHome.Name = "btnRegistrationHome";
            this.btnRegistrationHome.Size = new System.Drawing.Size(109, 42);
            this.btnRegistrationHome.TabIndex = 2;
            this.btnRegistrationHome.Text = "Registration";
            this.btnRegistrationHome.UseVisualStyleBackColor = true;
            this.btnRegistrationHome.Click += new System.EventHandler(this.BtnRegistrationHome_Click);
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoginHome.Location = new System.Drawing.Point(93, 255);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(108, 42);
            this.btnLoginHome.TabIndex = 1;
            this.btnLoginHome.Text = "Login";
            this.btnLoginHome.UseVisualStyleBackColor = false;
            this.btnLoginHome.Click += new System.EventHandler(this.BtnLoginHome_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 770);
            this.Controls.Add(this.pnlHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.pnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnExitHome;
        private System.Windows.Forms.Button btnRegistrationHome;
        private System.Windows.Forms.Button btnLoginHome;
    }
}

