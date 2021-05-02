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
    public partial class CitizenDeclinedRequest : MetroForm
    {
        CitizenHome ch;
        string nID;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public CitizenDeclinedRequest(CitizenHome ch,string id)
        {
            InitializeComponent();
            this.ch = ch;
            this.nID = id;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from denyrequest")
        {
            //sql = sql + "where nid= " + nID;
            string sql1 = "select * from denyrequest where nid=" + this.nID + ";";

            this.dgviewCitizenDeclined.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql1);
            this.dgviewCitizenDeclined.DataSource = this.Ds.Tables[0];
        }
        private void BtnHomeCitizenDeclinedRequest_Click(object sender, EventArgs e)
        {
            
            this.ch.Visible = true;
            this.Visible = false;
        }

        private void BtnsearchCitizenDeclinedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchCitizenDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchCitizenDeclinedRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from denyrequest where type like '" + this.txtBoxSearchCitizenDeclinedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
