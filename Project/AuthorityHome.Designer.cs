namespace CommunityServiceManagement
{
    partial class AuthorityHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoutAuthorityHome = new System.Windows.Forms.Button();
            this.btnCheckDeclinedAuthorityHome = new System.Windows.Forms.Button();
            this.btnCheckAcceptedAuthorityHome = new System.Windows.Forms.Button();
            this.btnCheckPendingAuthorityHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLogoutAuthorityHome);
            this.panel1.Controls.Add(this.btnCheckDeclinedAuthorityHome);
            this.panel1.Controls.Add(this.btnCheckAcceptedAuthorityHome);
            this.panel1.Controls.Add(this.btnCheckPendingAuthorityHome);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 658);
            this.panel1.TabIndex = 0;
            // 
            // btnLogoutAuthorityHome
            // 
            this.btnLogoutAuthorityHome.Location = new System.Drawing.Point(342, 541);
            this.btnLogoutAuthorityHome.Name = "btnLogoutAuthorityHome";
            this.btnLogoutAuthorityHome.Size = new System.Drawing.Size(175, 36);
            this.btnLogoutAuthorityHome.TabIndex = 4;
            this.btnLogoutAuthorityHome.Text = "Logout";
            this.btnLogoutAuthorityHome.UseVisualStyleBackColor = true;
            this.btnLogoutAuthorityHome.Click += new System.EventHandler(this.BtnLogoutAuthorityHome_Click);
            // 
            // btnCheckDeclinedAuthorityHome
            // 
            this.btnCheckDeclinedAuthorityHome.Location = new System.Drawing.Point(89, 348);
            this.btnCheckDeclinedAuthorityHome.Name = "btnCheckDeclinedAuthorityHome";
            this.btnCheckDeclinedAuthorityHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckDeclinedAuthorityHome.TabIndex = 2;
            this.btnCheckDeclinedAuthorityHome.Text = "Check Declined Request";
            this.btnCheckDeclinedAuthorityHome.UseVisualStyleBackColor = true;
            this.btnCheckDeclinedAuthorityHome.Click += new System.EventHandler(this.BtnCheckDeclinedAuthorityHome_Click);
            // 
            // btnCheckAcceptedAuthorityHome
            // 
            this.btnCheckAcceptedAuthorityHome.Location = new System.Drawing.Point(89, 279);
            this.btnCheckAcceptedAuthorityHome.Name = "btnCheckAcceptedAuthorityHome";
            this.btnCheckAcceptedAuthorityHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckAcceptedAuthorityHome.TabIndex = 1;
            this.btnCheckAcceptedAuthorityHome.Text = "Check Accepted Request";
            this.btnCheckAcceptedAuthorityHome.UseVisualStyleBackColor = true;
            this.btnCheckAcceptedAuthorityHome.Click += new System.EventHandler(this.BtnCheckAcceptedAuthorityHome_Click);
            // 
            // btnCheckPendingAuthorityHome
            // 
            this.btnCheckPendingAuthorityHome.Location = new System.Drawing.Point(89, 205);
            this.btnCheckPendingAuthorityHome.Name = "btnCheckPendingAuthorityHome";
            this.btnCheckPendingAuthorityHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckPendingAuthorityHome.TabIndex = 0;
            this.btnCheckPendingAuthorityHome.Text = "Check Pending Request";
            this.btnCheckPendingAuthorityHome.UseVisualStyleBackColor = true;
            this.btnCheckPendingAuthorityHome.Click += new System.EventHandler(this.BtnCheckPendingAuthorityHome_Click);
            // 
            // AuthorityHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 744);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorityHome";
            this.Text = "AuthorityHome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogoutAuthorityHome;
        private System.Windows.Forms.Button btnCheckDeclinedAuthorityHome;
        private System.Windows.Forms.Button btnCheckAcceptedAuthorityHome;
        private System.Windows.Forms.Button btnCheckPendingAuthorityHome;
    }
}