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
    public partial class PoliceDeclinedRequest : MetroForm
    {

        PoliceHome ph;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public PoliceDeclinedRequest(PoliceHome ph)
        {
            InitializeComponent();
            this.ph = ph;

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void BtnHomeAuthorityDeclinedRequest_Click(object sender, EventArgs e)
        {
            this.ph.Visible = true;
            this.Visible = false;
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

        private void BtnDeleteAuthorityDeclined_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgviewPoliceDeclined.CurrentRow.Cells["nid"].Value.ToString();
                string name = this.dgviewPoliceDeclined.CurrentRow.Cells["name"].Value.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
            }
        }

        private void DgviewPoliceDeclined_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxNidAuthorityDeclinded.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["nid"].Value.ToString();
            this.txtboxNameApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["name"].Value.ToString();
            this.txtboxPhoneApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["phone"].Value.ToString();
            this.dtpApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["dob"].Value.ToString();
            this.txtboxEmailApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["email"].Value.ToString();
            this.txtboxAddressApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["address"].Value.ToString();
            this.txtboxGenderApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["gender"].Value.ToString();
            this.txtboxBloodGroupApplyForBc.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtboxAuthorityDeclinedRequestType.Text = this.dgviewPoliceDeclined.CurrentRow.Cells["type"].Value.ToString();
            MessageBox.Show("Data has been pushed from grid.");
        }

        private void PopulateGridView(string sql = "select * from denyrequest where type='police clearance';;")
        {
            this.dgviewPoliceDeclined.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgviewPoliceDeclined.DataSource = this.Ds.Tables[0];
        }

        private void BtnsearchPoliceDeclinedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchPoliceDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxPoliceDeclinedRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchPoliceDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
