using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace CommunityServiceManagement
{
    public partial class PolicePendingRequest : MetroForm
    {
        PoliceHome ph;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public PolicePendingRequest(PoliceHome ph)
        {
            InitializeComponent();
            this.ph = ph;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from pendingrequest where type='police clearance';")
        {
            this.dgvviewPolicePending.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvviewPolicePending.DataSource = this.Ds.Tables[0];
        }

        private void BtnHomePolicePendingRequest_Click(object sender, EventArgs e)
        {
            this.ph.Visible = true;
            this.Visible = false;
        }

        private void BtnAcceptPolicePendingRequest_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string sql = @"insert into acceptrequest(nid, name, phone, dob, email, address, gender, bloodgroup, type)select* from pendingrequest where nid = " + this.txtboxNidAuthorityPending.Text + ";";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Done");

                    string sql2 = @"delete from pendingrequest where nid=" +this.txtboxNidAuthorityPending.Text+ ";";
                    int count1 = this.Da.ExecuteUpdateQuery(sql2);
                    MessageBox.Show("Done");
                    this.PopulateGridView();
                this.txtboxNidAuthorityPending.Text = "";
                this.txtboxNameApplyForBc.Text = "";
                this.txtboxPhoneApplyForBc.Text = "";
                this.dtpApplyForBc.Text = "";
                this.txtboxEmailApplyForBc.Text = "";
                this.txtboxAddressApplyForBc.Text = "";
                this.txtboxGenderApplyForBc.Text = "";
                this.txtboxBloodGroupApplyForBc.Text = "";
                this.txtboxAuthorityPendingRequest.Text = "";

            }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception:" + ex);
                }
            
        }

        private void BtnDeclinePolicePendingRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into denyrequest(nid, name, phone, dob, email, address, gender, bloodgroup, type)select* from pendingrequest where nid = " + this.txtboxNidAuthorityPending.Text + ";";
                int count = this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Done");
                string sql2 = @"delete from pendingrequest where nid="+this.txtboxNidAuthorityPending.Text+";";
                int count1 = this.Da.ExecuteUpdateQuery(sql2);
                MessageBox.Show("Done");
                this.PopulateGridView();
                this.txtboxNidAuthorityPending.Text = "";
                this.txtboxNameApplyForBc.Text = "";
                this.txtboxPhoneApplyForBc.Text = "";
                this.dtpApplyForBc.Text = "";
                this.txtboxEmailApplyForBc.Text = "";
                this.txtboxAddressApplyForBc.Text = "";
                this.txtboxGenderApplyForBc.Text = "";
                this.txtboxBloodGroupApplyForBc.Text = "";
                this.txtboxAuthorityPendingRequest.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
            }
        }

        private void DgvviewPolicePending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxNidAuthorityPending.Text = this.dgvviewPolicePending.CurrentRow.Cells["nid"].Value.ToString();
            this.txtboxNameApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["name"].Value.ToString();
            this.txtboxPhoneApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["phone"].Value.ToString();
            this.dtpApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["dob"].Value.ToString();
            this.txtboxEmailApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["email"].Value.ToString();
            this.txtboxAddressApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["address"].Value.ToString();
            this.txtboxGenderApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["gender"].Value.ToString();
            this.txtboxBloodGroupApplyForBc.Text = this.dgvviewPolicePending.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtboxAuthorityPendingRequest.Text = this.dgvviewPolicePending.CurrentRow.Cells["type"].Value.ToString();
            MessageBox.Show("Data has been pushed from grid.");
        }

        private void BtnsearchAuthorityPendingRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtBoxSearchPolicePending.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchPolicePending_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtBoxSearchPolicePending.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
