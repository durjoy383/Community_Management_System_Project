namespace CommunityServiceManagement
{
    partial class ApplyForm
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
            this.pnlCitizenRegistration = new System.Windows.Forms.Panel();
            this.cmbBoxCitizenApply = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbboxTypeApplyForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNidBirtchCertificate = new System.Windows.Forms.TextBox();
            this.lblDOBCitizen = new System.Windows.Forms.Label();
            this.dtpApplyForBc = new System.Windows.Forms.DateTimePicker();
            this.btnBackApplyForBc = new System.Windows.Forms.Button();
            this.btnConfirmApplyForBc = new System.Windows.Forms.Button();
            this.lblBloodGroupCitizen = new System.Windows.Forms.Label();
            this.lblGenderCitizen = new System.Windows.Forms.Label();
            this.lblAddressCitizen = new System.Windows.Forms.Label();
            this.lblEmailCitizen = new System.Windows.Forms.Label();
            this.lblPhoneCitizen = new System.Windows.Forms.Label();
            this.lblNameCitizen = new System.Windows.Forms.Label();
            this.txtboxBloodGroupApplyForBc = new System.Windows.Forms.TextBox();
            this.txtboxAddressApplyForBc = new System.Windows.Forms.TextBox();
            this.txtboxEmailApplyForBc = new System.Windows.Forms.TextBox();
            this.txtboxPhoneApplyForBc = new System.Windows.Forms.TextBox();
            this.txtboxNameApplyForBc = new System.Windows.Forms.TextBox();
            this.pnlCitizenRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCitizenRegistration
            // 
            this.pnlCitizenRegistration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCitizenRegistration.Controls.Add(this.cmbBoxCitizenApply);
            this.pnlCitizenRegistration.Controls.Add(this.label2);
            this.pnlCitizenRegistration.Controls.Add(this.cmbboxTypeApplyForm);
            this.pnlCitizenRegistration.Controls.Add(this.label1);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxNidBirtchCertificate);
            this.pnlCitizenRegistration.Controls.Add(this.lblDOBCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.dtpApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.btnBackApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.btnConfirmApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.lblBloodGroupCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.lblGenderCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.lblAddressCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.lblEmailCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.lblPhoneCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.lblNameCitizen);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxBloodGroupApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxAddressApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxEmailApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxPhoneApplyForBc);
            this.pnlCitizenRegistration.Controls.Add(this.txtboxNameApplyForBc);
            this.pnlCitizenRegistration.Location = new System.Drawing.Point(23, 63);
            this.pnlCitizenRegistration.Name = "pnlCitizenRegistration";
            this.pnlCitizenRegistration.Size = new System.Drawing.Size(472, 658);
            this.pnlCitizenRegistration.TabIndex = 2;
            // 
            // cmbBoxCitizenApply
            // 
            this.cmbBoxCitizenApply.FormattingEnabled = true;
            this.cmbBoxCitizenApply.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxCitizenApply.Location = new System.Drawing.Point(148, 338);
            this.cmbBoxCitizenApply.Name = "cmbBoxCitizenApply";
            this.cmbBoxCitizenApply.Size = new System.Drawing.Size(219, 24);
            this.cmbBoxCitizenApply.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Application Type";
            // 
            // cmbboxTypeApplyForm
            // 
            this.cmbboxTypeApplyForm.FormattingEnabled = true;
            this.cmbboxTypeApplyForm.Items.AddRange(new object[] {
            "Birth Certificate",
            "Character Certificate",
            "Legacy Certificate",
            "Police Clearance"});
            this.cmbboxTypeApplyForm.Location = new System.Drawing.Point(168, 453);
            this.cmbboxTypeApplyForm.Name = "cmbboxTypeApplyForm";
            this.cmbboxTypeApplyForm.Size = new System.Drawing.Size(199, 24);
            this.cmbboxTypeApplyForm.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "NID";
            // 
            // txtboxNidBirtchCertificate
            // 
            this.txtboxNidBirtchCertificate.Location = new System.Drawing.Point(148, 15);
            this.txtboxNidBirtchCertificate.Multiline = true;
            this.txtboxNidBirtchCertificate.Name = "txtboxNidBirtchCertificate";
            this.txtboxNidBirtchCertificate.Size = new System.Drawing.Size(219, 37);
            this.txtboxNidBirtchCertificate.TabIndex = 22;
            // 
            // lblDOBCitizen
            // 
            this.lblDOBCitizen.AutoSize = true;
            this.lblDOBCitizen.Location = new System.Drawing.Point(40, 174);
            this.lblDOBCitizen.Name = "lblDOBCitizen";
            this.lblDOBCitizen.Size = new System.Drawing.Size(90, 17);
            this.lblDOBCitizen.TabIndex = 19;
            this.lblDOBCitizen.Text = "Date Of Birth";
            // 
            // dtpApplyForBc
            // 
            this.dtpApplyForBc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApplyForBc.Location = new System.Drawing.Point(148, 169);
            this.dtpApplyForBc.Name = "dtpApplyForBc";
            this.dtpApplyForBc.Size = new System.Drawing.Size(219, 22);
            this.dtpApplyForBc.TabIndex = 18;
            // 
            // btnBackApplyForBc
            // 
            this.btnBackApplyForBc.Location = new System.Drawing.Point(266, 591);
            this.btnBackApplyForBc.Name = "btnBackApplyForBc";
            this.btnBackApplyForBc.Size = new System.Drawing.Size(89, 32);
            this.btnBackApplyForBc.TabIndex = 17;
            this.btnBackApplyForBc.Text = "Back";
            this.btnBackApplyForBc.UseVisualStyleBackColor = true;
            this.btnBackApplyForBc.Click += new System.EventHandler(this.BtnBackApplyForBc_Click);
            // 
            // btnConfirmApplyForBc
            // 
            this.btnConfirmApplyForBc.Location = new System.Drawing.Point(46, 591);
            this.btnConfirmApplyForBc.Name = "btnConfirmApplyForBc";
            this.btnConfirmApplyForBc.Size = new System.Drawing.Size(116, 32);
            this.btnConfirmApplyForBc.TabIndex = 16;
            this.btnConfirmApplyForBc.Text = "Confirm";
            this.btnConfirmApplyForBc.UseVisualStyleBackColor = true;
            this.btnConfirmApplyForBc.Click += new System.EventHandler(this.BtnConfirmApplyForBc_Click);
            // 
            // lblBloodGroupCitizen
            // 
            this.lblBloodGroupCitizen.AutoSize = true;
            this.lblBloodGroupCitizen.Location = new System.Drawing.Point(43, 400);
            this.lblBloodGroupCitizen.Name = "lblBloodGroupCitizen";
            this.lblBloodGroupCitizen.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroupCitizen.TabIndex = 14;
            this.lblBloodGroupCitizen.Text = "Blood Group";
            // 
            // lblGenderCitizen
            // 
            this.lblGenderCitizen.AutoSize = true;
            this.lblGenderCitizen.Location = new System.Drawing.Point(43, 345);
            this.lblGenderCitizen.Name = "lblGenderCitizen";
            this.lblGenderCitizen.Size = new System.Drawing.Size(56, 17);
            this.lblGenderCitizen.TabIndex = 13;
            this.lblGenderCitizen.Text = "Gender";
            // 
            // lblAddressCitizen
            // 
            this.lblAddressCitizen.AutoSize = true;
            this.lblAddressCitizen.Location = new System.Drawing.Point(43, 291);
            this.lblAddressCitizen.Name = "lblAddressCitizen";
            this.lblAddressCitizen.Size = new System.Drawing.Size(60, 17);
            this.lblAddressCitizen.TabIndex = 12;
            this.lblAddressCitizen.Text = "Address";
            // 
            // lblEmailCitizen
            // 
            this.lblEmailCitizen.AutoSize = true;
            this.lblEmailCitizen.Location = new System.Drawing.Point(40, 235);
            this.lblEmailCitizen.Name = "lblEmailCitizen";
            this.lblEmailCitizen.Size = new System.Drawing.Size(42, 17);
            this.lblEmailCitizen.TabIndex = 11;
            this.lblEmailCitizen.Text = "Email";
            // 
            // lblPhoneCitizen
            // 
            this.lblPhoneCitizen.AutoSize = true;
            this.lblPhoneCitizen.Location = new System.Drawing.Point(43, 128);
            this.lblPhoneCitizen.Name = "lblPhoneCitizen";
            this.lblPhoneCitizen.Size = new System.Drawing.Size(49, 17);
            this.lblPhoneCitizen.TabIndex = 10;
            this.lblPhoneCitizen.Text = "Phone";
            // 
            // lblNameCitizen
            // 
            this.lblNameCitizen.AutoSize = true;
            this.lblNameCitizen.Location = new System.Drawing.Point(43, 77);
            this.lblNameCitizen.Name = "lblNameCitizen";
            this.lblNameCitizen.Size = new System.Drawing.Size(45, 17);
            this.lblNameCitizen.TabIndex = 8;
            this.lblNameCitizen.Text = "Name";
            // 
            // txtboxBloodGroupApplyForBc
            // 
            this.txtboxBloodGroupApplyForBc.Location = new System.Drawing.Point(148, 381);
            this.txtboxBloodGroupApplyForBc.Multiline = true;
            this.txtboxBloodGroupApplyForBc.Name = "txtboxBloodGroupApplyForBc";
            this.txtboxBloodGroupApplyForBc.Size = new System.Drawing.Size(219, 36);
            this.txtboxBloodGroupApplyForBc.TabIndex = 6;
            // 
            // txtboxAddressApplyForBc
            // 
            this.txtboxAddressApplyForBc.Location = new System.Drawing.Point(148, 272);
            this.txtboxAddressApplyForBc.Multiline = true;
            this.txtboxAddressApplyForBc.Name = "txtboxAddressApplyForBc";
            this.txtboxAddressApplyForBc.Size = new System.Drawing.Size(219, 36);
            this.txtboxAddressApplyForBc.TabIndex = 4;
            // 
            // txtboxEmailApplyForBc
            // 
            this.txtboxEmailApplyForBc.Location = new System.Drawing.Point(148, 216);
            this.txtboxEmailApplyForBc.Multiline = true;
            this.txtboxEmailApplyForBc.Name = "txtboxEmailApplyForBc";
            this.txtboxEmailApplyForBc.Size = new System.Drawing.Size(219, 36);
            this.txtboxEmailApplyForBc.TabIndex = 3;
            // 
            // txtboxPhoneApplyForBc
            // 
            this.txtboxPhoneApplyForBc.Location = new System.Drawing.Point(148, 109);
            this.txtboxPhoneApplyForBc.Multiline = true;
            this.txtboxPhoneApplyForBc.Name = "txtboxPhoneApplyForBc";
            this.txtboxPhoneApplyForBc.Size = new System.Drawing.Size(219, 36);
            this.txtboxPhoneApplyForBc.TabIndex = 2;
            // 
            // txtboxNameApplyForBc
            // 
            this.txtboxNameApplyForBc.Location = new System.Drawing.Point(148, 58);
            this.txtboxNameApplyForBc.Multiline = true;
            this.txtboxNameApplyForBc.Name = "txtboxNameApplyForBc";
            this.txtboxNameApplyForBc.Size = new System.Drawing.Size(219, 36);
            this.txtboxNameApplyForBc.TabIndex = 0;
            // 
            // ApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 749);
            this.Controls.Add(this.pnlCitizenRegistration);
            this.Name = "ApplyForm";
            this.Text = "ApplyForm";
            this.pnlCitizenRegistration.ResumeLayout(false);
            this.pnlCitizenRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCitizenRegistration;
        private System.Windows.Forms.Label lblDOBCitizen;
        private System.Windows.Forms.DateTimePicker dtpApplyForBc;
        private System.Windows.Forms.Button btnBackApplyForBc;
        private System.Windows.Forms.Button btnConfirmApplyForBc;
        private System.Windows.Forms.Label lblBloodGroupCitizen;
        private System.Windows.Forms.Label lblGenderCitizen;
        private System.Windows.Forms.Label lblAddressCitizen;
        private System.Windows.Forms.Label lblEmailCitizen;
        private System.Windows.Forms.Label lblPhoneCitizen;
        private System.Windows.Forms.Label lblNameCitizen;
        private System.Windows.Forms.TextBox txtboxAddressApplyForBc;
        private System.Windows.Forms.TextBox txtboxEmailApplyForBc;
        private System.Windows.Forms.TextBox txtboxPhoneApplyForBc;
        private System.Windows.Forms.TextBox txtboxNameApplyForBc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNidBirtchCertificate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbboxTypeApplyForm;
        private System.Windows.Forms.TextBox txtboxBloodGroupApplyForBc;
        private System.Windows.Forms.ComboBox cmbBoxCitizenApply;
    }
}