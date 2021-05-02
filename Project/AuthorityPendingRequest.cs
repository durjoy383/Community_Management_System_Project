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
    public partial class AuthorityPendingRequest : MetroForm
    {
        AuthorityHome ah;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public AuthorityPendingRequest(AuthorityHome ah)
        {
            InitializeComponent();
            this.ah = ah;

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from pendingrequest where type='birth certificate' or type='legacy certificate'or type='character certificate';")
        {
            this.dgvviewAuthorityPending.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvviewAuthorityPending.DataSource = this.Ds.Tables[0];
        }

        private void BtnHomeAuthorityPendingRequest_Click(object sender, EventArgs e)
        {

            this.ah.Visible = true;
            this.Visible = false;
        }

        private void DgvviewAuthorityPending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxNidAuthorityPending.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["nid"].Value.ToString();
            this.txtboxNameApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["name"].Value.ToString();
            this.txtboxPhoneApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["phone"].Value.ToString();
            this.dtpApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["dob"].Value.ToString();
            this.txtboxEmailApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["email"].Value.ToString();
            this.txtboxAddressApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["address"].Value.ToString();
            this.txtboxGenderApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["gender"].Value.ToString();
            this.txtboxBloodGroupApplyForBc.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtboxAuthorityPendingRequest.Text = this.dgvviewAuthorityPending.CurrentRow.Cells["type"].Value.ToString();
            MessageBox.Show("Data has been pushed from grid.");
        }

        private void BtnAcceptAuthorityPendingRequest_Click(object sender, EventArgs e)
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

        private void BtnDeclineAuthorityPendingRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into denyrequest(nid, name, phone, dob, email, address, gender, bloodgroup, type)select* from pendingrequest where nid = " + this.txtboxNidAuthorityPending.Text + ";";
                int count = this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Done");
                //string id=this.dgvviewAuthorityPending.CurrentRow.Cells["nid"].Value.ToString();
                //string sql2 = "delete from denyrequest where nid = '" + id + "';";
                //this.Da.ExecuteUpdateQuery(sql2);
                //MessageBox.Show(name + " has been deleted.");
                
                string sql2 = @"delete from pendingrequest where nid="+this.txtboxNidAuthorityPending.Text+";";
                this.Da.ExecuteUpdateQuery(sql2);
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

        private void TxtboxSearchAuthorityPendingRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtboxSearchAuthorityPendingRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void BtnsearchAuthorityPendingRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtboxSearchAuthorityPendingRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}

