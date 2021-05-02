namespace CommunityServiceManagement
{
    partial class CitizenDeclinedRequest
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
            this.btnsearchCitizenDeclinedRequest = new System.Windows.Forms.Button();
            this.txtBoxSearchCitizenDeclinedRequest = new System.Windows.Forms.TextBox();
            this.dgviewCitizenDeclined = new System.Windows.Forms.DataGridView();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomeCitizenDeclinedRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCitizenDeclined)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnsearchCitizenDeclinedRequest);
            this.panel1.Controls.Add(this.txtBoxSearchCitizenDeclinedRequest);
            this.panel1.Controls.Add(this.dgviewCitizenDeclined);
            this.panel1.Controls.Add(this.btnHomeCitizenDeclinedRequest);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 728);
            this.panel1.TabIndex = 2;
            // 
            // btnsearchCitizenDeclinedRequest
            // 
            this.btnsearchCitizenDeclinedRequest.Location = new System.Drawing.Point(881, 125);
            this.btnsearchCitizenDeclinedRequest.Name = "btnsearchCitizenDeclinedRequest";
            this.btnsearchCitizenDeclinedRequest.Size = new System.Drawing.Size(167, 47);
            this.btnsearchCitizenDeclinedRequest.TabIndex = 39;
            this.btnsearchCitizenDeclinedRequest.Text = "Search";
            this.btnsearchCitizenDeclinedRequest.UseVisualStyleBackColor = true;
            this.btnsearchCitizenDeclinedRequest.Click += new System.EventHandler(this.BtnsearchCitizenDeclinedRequest_Click);
            // 
            // txtBoxSearchCitizenDeclinedRequest
            // 
            this.txtBoxSearchCitizenDeclinedRequest.Location = new System.Drawing.Point(684, 125);
            this.txtBoxSearchCitizenDeclinedRequest.Multiline = true;
            this.txtBoxSearchCitizenDeclinedRequest.Name = "txtBoxSearchCitizenDeclinedRequest";
            this.txtBoxSearchCitizenDeclinedRequest.Size = new System.Drawing.Size(142, 36);
            this.txtBoxSearchCitizenDeclinedRequest.TabIndex = 38;
            this.txtBoxSearchCitizenDeclinedRequest.TextChanged += new System.EventHandler(this.TxtBoxSearchCitizenDeclinedRequest_TextChanged);
            // 
            // dgviewCitizenDeclined
            // 
            this.dgviewCitizenDeclined.AllowUserToDeleteRows = false;
            this.dgviewCitizenDeclined.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewCitizenDeclined.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewCitizenDeclined.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nid,
            this.name,
            this.phone,
            this.dob,
            this.email,
            this.address,
            this.gender,
            this.bloodgroup,
            this.type});
            this.dgviewCitizenDeclined.Location = new System.Drawing.Point(3, 193);
            this.dgviewCitizenDeclined.Name = "dgviewCitizenDeclined";
            this.dgviewCitizenDeclined.ReadOnly = true;
            this.dgviewCitizenDeclined.RowHeadersWidth = 51;
            this.dgviewCitizenDeclined.RowTemplate.Height = 24;
            this.dgviewCitizenDeclined.Size = new System.Drawing.Size(1073, 532);
            this.dgviewCitizenDeclined.TabIndex = 5;
            // 
            // nid
            // 
            this.nid.DataPropertyName = "nid";
            this.nid.HeaderText = "NID";
            this.nid.MinimumWidth = 6;
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "PHONE";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DATE OF BIRTH";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BLOOD GROUP";
            this.bloodgroup.MinimumWidth = 6;
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "TYPE";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // btnHomeCitizenDeclinedRequest
            // 
            this.btnHomeCitizenDeclinedRequest.Location = new System.Drawing.Point(881, 46);
            this.btnHomeCitizenDeclinedRequest.Name = "btnHomeCitizenDeclinedRequest";
            this.btnHomeCitizenDeclinedRequest.Size = new System.Drawing.Size(167, 47);
            this.btnHomeCitizenDeclinedRequest.TabIndex = 3;
            this.btnHomeCitizenDeclinedRequest.Text = "Home";
            this.btnHomeCitizenDeclinedRequest.UseVisualStyleBackColor = true;
            this.btnHomeCitizenDeclinedRequest.Click += new System.EventHandler(this.BtnHomeCitizenDeclinedRequest_Click);
            // 
            // CitizenDeclinedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 814);
            this.Controls.Add(this.panel1);
            this.Name = "CitizenDeclinedRequest";
            this.Text = "CitizenDeclinedRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCitizenDeclined)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomeCitizenDeclinedRequest;
        private System.Windows.Forms.DataGridView dgviewCitizenDeclined;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button btnsearchCitizenDeclinedRequest;
        private System.Windows.Forms.TextBox txtBoxSearchCitizenDeclinedRequest;
    }
}