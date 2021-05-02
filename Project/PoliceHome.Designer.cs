namespace CommunityServiceManagement
{
    partial class PoliceHome
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
            this.pnlPoliceHome = new System.Windows.Forms.Panel();
            this.btnLogoutPoliceHome = new System.Windows.Forms.Button();
            this.btnCheckDeclinedPoliceHome = new System.Windows.Forms.Button();
            this.btnCheckAcceptedPoliceHome = new System.Windows.Forms.Button();
            this.btnCheckPendingPoliceHome = new System.Windows.Forms.Button();
            this.pnlPoliceHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPoliceHome
            // 
            this.pnlPoliceHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPoliceHome.Controls.Add(this.btnLogoutPoliceHome);
            this.pnlPoliceHome.Controls.Add(this.btnCheckDeclinedPoliceHome);
            this.pnlPoliceHome.Controls.Add(this.btnCheckAcceptedPoliceHome);
            this.pnlPoliceHome.Controls.Add(this.btnCheckPendingPoliceHome);
            this.pnlPoliceHome.Location = new System.Drawing.Point(17, 120);
            this.pnlPoliceHome.Name = "pnlPoliceHome";
            this.pnlPoliceHome.Size = new System.Drawing.Size(589, 658);
            this.pnlPoliceHome.TabIndex = 1;
            // 
            // btnLogoutPoliceHome
            // 
            this.btnLogoutPoliceHome.Location = new System.Drawing.Point(342, 541);
            this.btnLogoutPoliceHome.Name = "btnLogoutPoliceHome";
            this.btnLogoutPoliceHome.Size = new System.Drawing.Size(175, 36);
            this.btnLogoutPoliceHome.TabIndex = 4;
            this.btnLogoutPoliceHome.Text = "Logout";
            this.btnLogoutPoliceHome.UseVisualStyleBackColor = true;
            this.btnLogoutPoliceHome.Click += new System.EventHandler(this.BtnLogoutPoliceHome_Click);
            // 
            // btnCheckDeclinedPoliceHome
            // 
            this.btnCheckDeclinedPoliceHome.Location = new System.Drawing.Point(89, 348);
            this.btnCheckDeclinedPoliceHome.Name = "btnCheckDeclinedPoliceHome";
            this.btnCheckDeclinedPoliceHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckDeclinedPoliceHome.TabIndex = 2;
            this.btnCheckDeclinedPoliceHome.Text = "Check Declined Request";
            this.btnCheckDeclinedPoliceHome.UseVisualStyleBackColor = true;
            this.btnCheckDeclinedPoliceHome.Click += new System.EventHandler(this.BtnCheckDeclinedPoliceHome_Click);
            // 
            // btnCheckAcceptedPoliceHome
            // 
            this.btnCheckAcceptedPoliceHome.Location = new System.Drawing.Point(89, 279);
            this.btnCheckAcceptedPoliceHome.Name = "btnCheckAcceptedPoliceHome";
            this.btnCheckAcceptedPoliceHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckAcceptedPoliceHome.TabIndex = 1;
            this.btnCheckAcceptedPoliceHome.Text = "Check Accepted Request";
            this.btnCheckAcceptedPoliceHome.UseVisualStyleBackColor = true;
            this.btnCheckAcceptedPoliceHome.Click += new System.EventHandler(this.BtnCheckAcceptedPoliceHome_Click);
            // 
            // btnCheckPendingPoliceHome
            // 
            this.btnCheckPendingPoliceHome.Location = new System.Drawing.Point(89, 205);
            this.btnCheckPendingPoliceHome.Name = "btnCheckPendingPoliceHome";
            this.btnCheckPendingPoliceHome.Size = new System.Drawing.Size(200, 36);
            this.btnCheckPendingPoliceHome.TabIndex = 0;
            this.btnCheckPendingPoliceHome.Text = "Check Pending Request";
            this.btnCheckPendingPoliceHome.UseVisualStyleBackColor = true;
            this.btnCheckPendingPoliceHome.Click += new System.EventHandler(this.BtnCheckPendingPoliceHome_Click);
            // 
            // PoliceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 801);
            this.Controls.Add(this.pnlPoliceHome);
            this.Name = "PoliceHome";
            this.Text = "PoliceHome";
            this.pnlPoliceHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPoliceHome;
        private System.Windows.Forms.Button btnLogoutPoliceHome;
        private System.Windows.Forms.Button btnCheckDeclinedPoliceHome;
        private System.Windows.Forms.Button btnCheckAcceptedPoliceHome;
        private System.Windows.Forms.Button btnCheckPendingPoliceHome;
    }
}