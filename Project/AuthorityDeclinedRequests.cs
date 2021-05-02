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
    public partial class AuthorityDeclinedRequests : MetroForm
    {
        AuthorityHome ah;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public AuthorityDeclinedRequests(AuthorityHome ah)
        {
            InitializeComponent();
            this.ah = ah;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from denyrequest where type='birth certificate' or type='legacy certificate'or type='character certificate';;")
        {
            this.dgviewAuthorityDeclined.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgviewAuthorityDeclined.DataSource = this.Ds.Tables[0];
        }
        private void BtnHomeAuthorityDeclinedRequest_Click(object sender, EventArgs e)
        {
            
            this.ah.Visible = true;
            this.Visible = false;
        }

        private void DgviewAuthorityDeclined_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                this.txtboxNidAuthorityDeclinded.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["nid"].Value.ToString();
                this.txtboxNameApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["name"].Value.ToString();
                this.txtboxPhoneApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["phone"].Value.ToString();
                this.dtpApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["dob"].Value.ToString();
                this.txtboxEmailApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["email"].Value.ToString();
                this.txtboxAddressApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["address"].Value.ToString();
                this.txtboxGenderApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["gender"].Value.ToString();
                this.txtboxBloodGroupApplyForBc.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["bloodgroup"].Value.ToString();
                this.txtboxAuthorityDeclinedRequestType.Text = this.dgviewAuthorityDeclined.CurrentRow.Cells["type"].Value.ToString();
                MessageBox.Show("Data has been pushed from grid.");
            }
        }

        private void BtnDeleteAuthorityDeclined_Click(object sender, EventArgs e)
        {


            try
            {
                string id = this.dgviewAuthorityDeclined.CurrentRow.Cells["nid"].Value.ToString();
                string name = this.dgviewAuthorityDeclined.CurrentRow.Cells["name"].Value.ToString();
                string sql = "delete from denyrequest where nid = '" + id + "';";
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show(name + " has been deleted.");
                this.PopulateGridView();
                this.txtboxNidAuthorityDeclinded.Text = "";
                this.txtboxNameApplyForBc.Text = "";
                this.txtboxPhoneApplyForBc.Text = "";
                this.dtpApplyForBc.Text = "";
                this.txtboxEmailApplyForBc.Text = "";
                this.txtboxAddressApplyForBc.Text = "";
                this.txtboxGenderApplyForBc.Text = "";
                this.txtboxBloodGroupApplyForBc.Text = "";
                this.txtboxAuthorityDeclinedRequestType.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
            }
            
        }

        private void BtnAcceptAuthorityDeclinedRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into acceptrequest(nid, name, phone, dob, email, address, gender, bloodgroup, type)select* from denyrequest where nid = " + this.txtboxNidAuthorityDeclinded.Text + ";";
                int count = this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Done");
                string sql2 = @"delete from denyrequest where nid=" + this.txtboxNidAuthorityDeclinded.Text + ";";
                int count1 = this.Da.ExecuteUpdateQuery(sql2);
                MessageBox.Show("Done");
                this.PopulateGridView();

                this.txtboxNidAuthorityDeclinded.Text = "";
                this.txtboxNameApplyForBc.Text = "";
                this.txtboxPhoneApplyForBc.Text = "";
                this.dtpApplyForBc.Text = "";
                this.txtboxEmailApplyForBc.Text = "";
                this.txtboxAddressApplyForBc.Text = "";
                this.txtboxGenderApplyForBc.Text = "";
                this.txtboxBloodGroupApplyForBc.Text = "";
                this.txtboxAuthorityDeclinedRequestType.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
            }
        }

        private void BtnsearchAuthorityDeclinedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchAuthorityDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchAuthorityDeclinedRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchAuthorityDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
