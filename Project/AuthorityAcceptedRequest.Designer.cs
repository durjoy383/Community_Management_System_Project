namespace CommunityServiceManagement
{
    partial class AuthorityAcceptedRequest
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
            this.dgviewAuthorityAccepted = new System.Windows.Forms.DataGridView();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomeAuthorityAcceptedRequest = new System.Windows.Forms.Button();
            this.btnsearchAuthorityAcceptedRequest = new System.Windows.Forms.Button();
            this.txtBoxSearchAuthorityAcceptedRequest = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAuthorityAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgviewAuthorityAccepted);
            this.panel1.Controls.Add(this.btnHomeAuthorityAcceptedRequest);
            this.panel1.Controls.Add(this.btnsearchAuthorityAcceptedRequest);
            this.panel1.Controls.Add(this.txtBoxSearchAuthorityAcceptedRequest);
            this.panel1.Location = new System.Drawing.Point(23, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 764);
            this.panel1.TabIndex = 2;
            // 
            // dgviewAuthorityAccepted
            // 
            this.dgviewAuthorityAccepted.AllowUserToDeleteRows = false;
            this.dgviewAuthorityAccepted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewAuthorityAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewAuthorityAccepted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nid,
            this.name,
            this.phone,
            this.dob,
            this.email,
            this.address,
            this.gender,
            this.bloodgroup,
            this.type});
            this.dgviewAuthorityAccepted.Location = new System.Drawing.Point(3, 220);
            this.dgviewAuthorityAccepted.Name = "dgviewAuthorityAccepted";
            this.dgviewAuthorityAccepted.ReadOnly = true;
            this.dgviewAuthorityAccepted.RowHeadersWidth = 51;
            this.dgviewAuthorityAccepted.RowTemplate.Height = 24;
            this.dgviewAuthorityAccepted.Size = new System.Drawing.Size(1089, 532);
            this.dgviewAuthorityAccepted.TabIndex = 5;
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
            // btnHomeAuthorityAcceptedRequest
            // 
            this.btnHomeAuthorityAcceptedRequest.Location = new System.Drawing.Point(927, 147);
            this.btnHomeAuthorityAcceptedRequest.Name = "btnHomeAuthorityAcceptedRequest";
            this.btnHomeAuthorityAcceptedRequest.Size = new System.Drawing.Size(148, 37);
            this.btnHomeAuthorityAcceptedRequest.TabIndex = 38;
            this.btnHomeAuthorityAcceptedRequest.Text = "Home";
            this.btnHomeAuthorityAcceptedRequest.UseVisualStyleBackColor = true;
            this.btnHomeAuthorityAcceptedRequest.Click += new System.EventHandler(this.BtnHomeAuthorityAcceptedRequest_Click);
            // 
            // btnsearchAuthorityAcceptedRequest
            // 
            this.btnsearchAuthorityAcceptedRequest.Location = new System.Drawing.Point(976, 38);
            this.btnsearchAuthorityAcceptedRequest.Name = "btnsearchAuthorityAcceptedRequest";
            this.btnsearchAuthorityAcceptedRequest.Size = new System.Drawing.Size(99, 36);
            this.btnsearchAuthorityAcceptedRequest.TabIndex = 37;
            this.btnsearchAuthorityAcceptedRequest.Text = "Search";
            this.btnsearchAuthorityAcceptedRequest.UseVisualStyleBackColor = true;
            this.btnsearchAuthorityAcceptedRequest.Click += new System.EventHandler(this.BtnsearchAuthorityAcceptedRequest_Click);
            // 
            // txtBoxSearchAuthorityAcceptedRequest
            // 
            this.txtBoxSearchAuthorityAcceptedRequest.Location = new System.Drawing.Point(770, 38);
            this.txtBoxSearchAuthorityAcceptedRequest.Multiline = true;
            this.txtBoxSearchAuthorityAcceptedRequest.Name = "txtBoxSearchAuthorityAcceptedRequest";
            this.txtBoxSearchAuthorityAcceptedRequest.Size = new System.Drawing.Size(142, 36);
            this.txtBoxSearchAuthorityAcceptedRequest.TabIndex = 36;
            this.txtBoxSearchAuthorityAcceptedRequest.TextChanged += new System.EventHandler(this.TxtBoxSearchAuthorityAcceptedRequest_TextChanged);
            // 
            // AuthorityAcceptedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 844);
            this.Controls.Add(this.panel1);
            this.Name = "AuthorityAcceptedRequest";
            this.Text = "AuthorityAcceptedRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAuthorityAccepted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsearchAuthorityAcceptedRequest;
        private System.Windows.Forms.TextBox txtBoxSearchAuthorityAcceptedRequest;
        private System.Windows.Forms.Button btnHomeAuthorityAcceptedRequest;
        private System.Windows.Forms.DataGridView dgviewAuthorityAccepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}