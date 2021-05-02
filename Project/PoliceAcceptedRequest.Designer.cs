namespace CommunityServiceManagement
{
    partial class PoliceAcceptedRequest
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
            this.pnlPoliceAcceptedRequest = new System.Windows.Forms.Panel();
            this.dgviewPoliceAccepted = new System.Windows.Forms.DataGridView();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHomePoliceAcceptedRequest = new System.Windows.Forms.Button();
            this.btnsearchPoliceAcceptedRequest = new System.Windows.Forms.Button();
            this.txtBoxSearchPoliceAcceptedRequest = new System.Windows.Forms.TextBox();
            this.pnlPoliceAcceptedRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewPoliceAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPoliceAcceptedRequest
            // 
            this.pnlPoliceAcceptedRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPoliceAcceptedRequest.Controls.Add(this.dgviewPoliceAccepted);
            this.pnlPoliceAcceptedRequest.Controls.Add(this.btnHomePoliceAcceptedRequest);
            this.pnlPoliceAcceptedRequest.Controls.Add(this.btnsearchPoliceAcceptedRequest);
            this.pnlPoliceAcceptedRequest.Controls.Add(this.txtBoxSearchPoliceAcceptedRequest);
            this.pnlPoliceAcceptedRequest.Location = new System.Drawing.Point(23, 63);
            this.pnlPoliceAcceptedRequest.Name = "pnlPoliceAcceptedRequest";
            this.pnlPoliceAcceptedRequest.Size = new System.Drawing.Size(1095, 764);
            this.pnlPoliceAcceptedRequest.TabIndex = 3;
            // 
            // dgviewPoliceAccepted
            // 
            this.dgviewPoliceAccepted.AllowUserToDeleteRows = false;
            this.dgviewPoliceAccepted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewPoliceAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewPoliceAccepted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nid,
            this.name,
            this.phone,
            this.dob,
            this.email,
            this.address,
            this.gender,
            this.bloodgroup,
            this.type});
            this.dgviewPoliceAccepted.Location = new System.Drawing.Point(3, 220);
            this.dgviewPoliceAccepted.Name = "dgviewPoliceAccepted";
            this.dgviewPoliceAccepted.ReadOnly = true;
            this.dgviewPoliceAccepted.RowHeadersWidth = 51;
            this.dgviewPoliceAccepted.RowTemplate.Height = 24;
            this.dgviewPoliceAccepted.Size = new System.Drawing.Size(1089, 532);
            this.dgviewPoliceAccepted.TabIndex = 5;
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
            // btnHomePoliceAcceptedRequest
            // 
            this.btnHomePoliceAcceptedRequest.Location = new System.Drawing.Point(927, 147);
            this.btnHomePoliceAcceptedRequest.Name = "btnHomePoliceAcceptedRequest";
            this.btnHomePoliceAcceptedRequest.Size = new System.Drawing.Size(148, 37);
            this.btnHomePoliceAcceptedRequest.TabIndex = 38;
            this.btnHomePoliceAcceptedRequest.Text = "Home";
            this.btnHomePoliceAcceptedRequest.UseVisualStyleBackColor = true;
            this.btnHomePoliceAcceptedRequest.Click += new System.EventHandler(this.BtnHomePoliceAcceptedRequest_Click);
            // 
            // btnsearchPoliceAcceptedRequest
            // 
            this.btnsearchPoliceAcceptedRequest.Location = new System.Drawing.Point(976, 38);
            this.btnsearchPoliceAcceptedRequest.Name = "btnsearchPoliceAcceptedRequest";
            this.btnsearchPoliceAcceptedRequest.Size = new System.Drawing.Size(99, 36);
            this.btnsearchPoliceAcceptedRequest.TabIndex = 37;
            this.btnsearchPoliceAcceptedRequest.Text = "Search";
            this.btnsearchPoliceAcceptedRequest.UseVisualStyleBackColor = true;
            this.btnsearchPoliceAcceptedRequest.Click += new System.EventHandler(this.BtnsearchPoliceAcceptedRequest_Click);
            // 
            // txtBoxSearchPoliceAcceptedRequest
            // 
            this.txtBoxSearchPoliceAcceptedRequest.Location = new System.Drawing.Point(770, 38);
            this.txtBoxSearchPoliceAcceptedRequest.Multiline = true;
            this.txtBoxSearchPoliceAcceptedRequest.Name = "txtBoxSearchPoliceAcceptedRequest";
            this.txtBoxSearchPoliceAcceptedRequest.Size = new System.Drawing.Size(142, 36);
            this.txtBoxSearchPoliceAcceptedRequest.TabIndex = 36;
            this.txtBoxSearchPoliceAcceptedRequest.TextChanged += new System.EventHandler(this.TxtBoxSearchPoliceAcceptedRequest_TextChanged);
            // 
            // PoliceAcceptedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 846);
            this.Controls.Add(this.pnlPoliceAcceptedRequest);
            this.Name = "PoliceAcceptedRequest";
            this.Text = "PoliceAcceptedRequest";
            this.pnlPoliceAcceptedRequest.ResumeLayout(false);
            this.pnlPoliceAcceptedRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewPoliceAccepted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPoliceAcceptedRequest;
        private System.Windows.Forms.DataGridView dgviewPoliceAccepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button btnHomePoliceAcceptedRequest;
        private System.Windows.Forms.Button btnsearchPoliceAcceptedRequest;
        private System.Windows.Forms.TextBox txtBoxSearchPoliceAcceptedRequest;
    }
}