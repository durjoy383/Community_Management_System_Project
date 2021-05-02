namespace CommunityServiceManagement
{
    partial class CitizenHome
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
            this.pnlCtznHome = new System.Windows.Forms.Panel();
            this.btnCheckDeclinedRequestCitizenHome = new System.Windows.Forms.Button();
            this.btnCheckAcceptReqCitizenHome = new System.Windows.Forms.Button();
            this.btnCheckReqCitizenHome = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnLogoutCitizenHome = new System.Windows.Forms.Button();
            this.pnlCtznHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtznHome
            // 
            this.pnlCtznHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCtznHome.Controls.Add(this.btnCheckDeclinedRequestCitizenHome);
            this.pnlCtznHome.Controls.Add(this.btnCheckAcceptReqCitizenHome);
            this.pnlCtznHome.Controls.Add(this.btnCheckReqCitizenHome);
            this.pnlCtznHome.Controls.Add(this.btnApply);
            this.pnlCtznHome.Location = new System.Drawing.Point(12, 153);
            this.pnlCtznHome.Name = "pnlCtznHome";
            this.pnlCtznHome.Size = new System.Drawing.Size(500, 585);
            this.pnlCtznHome.TabIndex = 0;
            // 
            // btnCheckDeclinedRequestCitizenHome
            // 
            this.btnCheckDeclinedRequestCitizenHome.Location = new System.Drawing.Point(152, 391);
            this.btnCheckDeclinedRequestCitizenHome.Name = "btnCheckDeclinedRequestCitizenHome";
            this.btnCheckDeclinedRequestCitizenHome.Size = new System.Drawing.Size(208, 54);
            this.btnCheckDeclinedRequestCitizenHome.TabIndex = 3;
            this.btnCheckDeclinedRequestCitizenHome.Text = "Check Declined Request";
            this.btnCheckDeclinedRequestCitizenHome.UseVisualStyleBackColor = true;
            this.btnCheckDeclinedRequestCitizenHome.Click += new System.EventHandler(this.BtnCheckDeclinedRequestCitizenHome_Click);
            // 
            // btnCheckAcceptReqCitizenHome
            // 
            this.btnCheckAcceptReqCitizenHome.Location = new System.Drawing.Point(152, 290);
            this.btnCheckAcceptReqCitizenHome.Name = "btnCheckAcceptReqCitizenHome";
            this.btnCheckAcceptReqCitizenHome.Size = new System.Drawing.Size(208, 56);
            this.btnCheckAcceptReqCitizenHome.TabIndex = 2;
            this.btnCheckAcceptReqCitizenHome.Text = "Check Accepted Requests";
            this.btnCheckAcceptReqCitizenHome.UseVisualStyleBackColor = true;
            this.btnCheckAcceptReqCitizenHome.Click += new System.EventHandler(this.BtnCheckAcceptReqCitizenHome_Click);
            // 
            // btnCheckReqCitizenHome
            // 
            this.btnCheckReqCitizenHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReqCitizenHome.Location = new System.Drawing.Point(152, 178);
            this.btnCheckReqCitizenHome.Name = "btnCheckReqCitizenHome";
            this.btnCheckReqCitizenHome.Size = new System.Drawing.Size(208, 56);
            this.btnCheckReqCitizenHome.TabIndex = 1;
            this.btnCheckReqCitizenHome.Text = "Check Pending Request";
            this.btnCheckReqCitizenHome.UseVisualStyleBackColor = true;
            this.btnCheckReqCitizenHome.Click += new System.EventHandler(this.BtnCheckReqCitizenHome_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(152, 85);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(208, 45);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // btnLogoutCitizenHome
            // 
            this.btnLogoutCitizenHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutCitizenHome.Location = new System.Drawing.Point(376, 79);
            this.btnLogoutCitizenHome.Name = "btnLogoutCitizenHome";
            this.btnLogoutCitizenHome.Size = new System.Drawing.Size(136, 36);
            this.btnLogoutCitizenHome.TabIndex = 2;
            this.btnLogoutCitizenHome.Text = "Logout";
            this.btnLogoutCitizenHome.UseVisualStyleBackColor = true;
            this.btnLogoutCitizenHome.Click += new System.EventHandler(this.BtnLogoutCitizenHome_Click);
            // 
            // CitizenHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 760);
            this.Controls.Add(this.btnLogoutCitizenHome);
            this.Controls.Add(this.pnlCtznHome);
            this.Name = "CitizenHome";
            this.Text = "CitizenHome";
            this.pnlCtznHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCtznHome;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnLogoutCitizenHome;
        private System.Windows.Forms.Button btnCheckReqCitizenHome;
        private System.Windows.Forms.Button btnCheckAcceptReqCitizenHome;
        private System.Windows.Forms.Button btnCheckDeclinedRequestCitizenHome;
    }
}