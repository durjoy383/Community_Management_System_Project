namespace CommunityServiceManagement
{
    partial class Registration
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
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxConfirmPasswordRegistration = new System.Windows.Forms.TextBox();
            this.btnNextRegistration = new System.Windows.Forms.Button();
            this.lblPasswordRegistration = new System.Windows.Forms.Label();
            this.lblNIDRegistration = new System.Windows.Forms.Label();
            this.btnBackRegistration = new System.Windows.Forms.Button();
            this.txtPasswordRegistration = new System.Windows.Forms.TextBox();
            this.txtNIDRegistration = new System.Windows.Forms.TextBox();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRegistration.Controls.Add(this.label1);
            this.pnlRegistration.Controls.Add(this.txtboxConfirmPasswordRegistration);
            this.pnlRegistration.Controls.Add(this.btnNextRegistration);
            this.pnlRegistration.Controls.Add(this.lblPasswordRegistration);
            this.pnlRegistration.Controls.Add(this.lblNIDRegistration);
            this.pnlRegistration.Controls.Add(this.btnBackRegistration);
            this.pnlRegistration.Controls.Add(this.txtPasswordRegistration);
            this.pnlRegistration.Controls.Add(this.txtNIDRegistration);
            this.pnlRegistration.Location = new System.Drawing.Point(20, 65);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(455, 618);
            this.pnlRegistration.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password";
            // 
            // txtboxConfirmPasswordRegistration
            // 
            this.txtboxConfirmPasswordRegistration.Location = new System.Drawing.Point(174, 312);
            this.txtboxConfirmPasswordRegistration.Multiline = true;
            this.txtboxConfirmPasswordRegistration.Name = "txtboxConfirmPasswordRegistration";
            this.txtboxConfirmPasswordRegistration.PasswordChar = '#';
            this.txtboxConfirmPasswordRegistration.Size = new System.Drawing.Size(207, 37);
            this.txtboxConfirmPasswordRegistration.TabIndex = 19;
            // 
            // btnNextRegistration
            // 
            this.btnNextRegistration.Location = new System.Drawing.Point(36, 495);
            this.btnNextRegistration.Name = "btnNextRegistration";
            this.btnNextRegistration.Size = new System.Drawing.Size(103, 34);
            this.btnNextRegistration.TabIndex = 18;
            this.btnNextRegistration.Text = "Next";
            this.btnNextRegistration.UseVisualStyleBackColor = true;
            this.btnNextRegistration.Click += new System.EventHandler(this.BtnNextRegistration_Click);
            // 
            // lblPasswordRegistration
            // 
            this.lblPasswordRegistration.AutoSize = true;
            this.lblPasswordRegistration.BackColor = System.Drawing.Color.White;
            this.lblPasswordRegistration.Location = new System.Drawing.Point(33, 261);
            this.lblPasswordRegistration.Name = "lblPasswordRegistration";
            this.lblPasswordRegistration.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordRegistration.TabIndex = 9;
            this.lblPasswordRegistration.Text = "Password";
            // 
            // lblNIDRegistration
            // 
            this.lblNIDRegistration.AutoSize = true;
            this.lblNIDRegistration.BackColor = System.Drawing.Color.White;
            this.lblNIDRegistration.Location = new System.Drawing.Point(33, 198);
            this.lblNIDRegistration.Name = "lblNIDRegistration";
            this.lblNIDRegistration.Size = new System.Drawing.Size(103, 17);
            this.lblNIDRegistration.TabIndex = 8;
            this.lblNIDRegistration.Text = "National ID No:";
            // 
            // btnBackRegistration
            // 
            this.btnBackRegistration.Location = new System.Drawing.Point(274, 495);
            this.btnBackRegistration.Name = "btnBackRegistration";
            this.btnBackRegistration.Size = new System.Drawing.Size(93, 33);
            this.btnBackRegistration.TabIndex = 7;
            this.btnBackRegistration.Text = "Back";
            this.btnBackRegistration.UseVisualStyleBackColor = true;
            this.btnBackRegistration.Click += new System.EventHandler(this.BtnBackRegistration_Click);
            // 
            // txtPasswordRegistration
            // 
            this.txtPasswordRegistration.Location = new System.Drawing.Point(174, 241);
            this.txtPasswordRegistration.Multiline = true;
            this.txtPasswordRegistration.Name = "txtPasswordRegistration";
            this.txtPasswordRegistration.PasswordChar = '#';
            this.txtPasswordRegistration.Size = new System.Drawing.Size(207, 37);
            this.txtPasswordRegistration.TabIndex = 1;
            // 
            // txtNIDRegistration
            // 
            this.txtNIDRegistration.Location = new System.Drawing.Point(174, 178);
            this.txtNIDRegistration.Multiline = true;
            this.txtNIDRegistration.Name = "txtNIDRegistration";
            this.txtNIDRegistration.Size = new System.Drawing.Size(207, 37);
            this.txtNIDRegistration.TabIndex = 0;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 713);
            this.Controls.Add(this.pnlRegistration);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.TextBox txtPasswordRegistration;
        private System.Windows.Forms.TextBox txtNIDRegistration;
        private System.Windows.Forms.Button btnBackRegistration;
        private System.Windows.Forms.Label lblPasswordRegistration;
        private System.Windows.Forms.Label lblNIDRegistration;
        private System.Windows.Forms.Button btnNextRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxConfirmPasswordRegistration;
    }
}