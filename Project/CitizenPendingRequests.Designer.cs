namespace CommunityServiceManagement
{
    partial class CitizenPendingRequests
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
            this.btnsearchCitizenPendingRequest = new System.Windows.Forms.Button();
            this.txtBoxSearchCitizenPendingRequest = new System.Windows.Forms.TextBox();
            this.dgviewCitizenPending = new System.Windows.Forms.DataGridView();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomeCitizenPendingRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCitizenPending)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnsearchCitizenPendingRequest);
            this.panel1.Controls.Add(this.txtBoxSearchCitizenPendingRequest);
            this.panel1.Controls.Add(this.dgviewCitizenPending);
            this.panel1.Controls.Add(this.btnHomeCitizenPendingRequest);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 712);
            this.panel1.TabIndex = 0;
            // 
            // btnsearchCitizenPendingRequest
            // 
            this.btnsearchCitizenPendingRequest.Location = new System.Drawing.Point(906, 106);
            this.btnsearchCitizenPendingRequest.Name = "btnsearchCitizenPendingRequest";
            this.btnsearchCitizenPendingRequest.Size = new System.Drawing.Size(130, 44);
            this.btnsearchCitizenPendingRequest.TabIndex = 39;
            this.btnsearchCitizenPendingRequest.Text = "Search";
            this.btnsearchCitizenPendingRequest.UseVisualStyleBackColor = true;
            this.btnsearchCitizenPendingRequest.Click += new System.EventHandler(this.BtnsearchCitizenPendingRequest_Click);
            // 
            // txtBoxSearchCitizenPendingRequest
            // 
            this.txtBoxSearchCitizenPendingRequest.Location = new System.Drawing.Point(700, 106);
            this.txtBoxSearchCitizenPendingRequest.Multiline = true;
            this.txtBoxSearchCitizenPendingRequest.Name = "txtBoxSearchCitizenPendingRequest";
            this.txtBoxSearchCitizenPendingRequest.Size = new System.Drawing.Size(159, 44);
            this.txtBoxSearchCitizenPendingRequest.TabIndex = 38;
            this.txtBoxSearchCitizenPendingRequest.TextChanged += new System.EventHandler(this.TxtBoxSearchCitizenPendingRequest_TextChanged);
            // 
            // dgviewCitizenPending
            // 
            this.dgviewCitizenPending.AllowUserToDeleteRows = false;
            this.dgviewCitizenPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewCitizenPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewCitizenPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nid,
            this.name,
            this.phone,
            this.dob,
            this.email,
            this.address,
            this.gender,
            this.bloodgroup,
            this.type});
            this.dgviewCitizenPending.Location = new System.Drawing.Point(3, 177);
            this.dgviewCitizenPending.Name = "dgviewCitizenPending";
            this.dgviewCitizenPending.ReadOnly = true;
            this.dgviewCitizenPending.RowHeadersWidth = 51;
            this.dgviewCitizenPending.RowTemplate.Height = 24;
            this.dgviewCitizenPending.Size = new System.Drawing.Size(1048, 532);
            this.dgviewCitizenPending.TabIndex = 5;
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
            // btnHomeCitizenPendingRequest
            // 
            this.btnHomeCitizenPendingRequest.Location = new System.Drawing.Point(907, 32);
            this.btnHomeCitizenPendingRequest.Name = "btnHomeCitizenPendingRequest";
            this.btnHomeCitizenPendingRequest.Size = new System.Drawing.Size(129, 45);
            this.btnHomeCitizenPendingRequest.TabIndex = 2;
            this.btnHomeCitizenPendingRequest.Text = "Home";
            this.btnHomeCitizenPendingRequest.UseVisualStyleBackColor = true;
            this.btnHomeCitizenPendingRequest.Click += new System.EventHandler(this.BtnHomeCitizenPendingRequest_Click);
            // 
            // CitizenPendingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 798);
            this.Controls.Add(this.panel1);
            this.Name = "CitizenPendingRequests";
            this.Text = "CitizenPendingRequests";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCitizenPending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomeCitizenPendingRequest;
        private System.Windows.Forms.DataGridView dgviewCitizenPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button btnsearchCitizenPendingRequest;
        private System.Windows.Forms.TextBox txtBoxSearchCitizenPendingRequest;
    }
}