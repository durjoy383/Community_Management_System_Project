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
    public partial class CitizenPendingRequests : MetroForm
    {
        CitizenHome ch;
        string nID;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public CitizenPendingRequests(CitizenHome ch,string id)
        {
            InitializeComponent();
            this.ch = ch;
            this.nID = id;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from pendingrequest")
        {
            //sql = sql + "where nid= " + nID;
            string sql1 = "select * from pendingrequest where nid=" + this.nID + ";";
            this.dgviewCitizenPending.AutoGenerateColumns = false;

            this.Ds = this.Da.ExecuteQuery(sql1);
            this.dgviewCitizenPending.DataSource = this.Ds.Tables[0];
        }

        private void BtnHomeCitizenPendingRequest_Click(object sender, EventArgs e)
        {
            
            this.ch.Visible = true;
            this.Visible = false;
        }

        private void BtnsearchCitizenPendingRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtBoxSearchCitizenPendingRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchCitizenPendingRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from pendingrequest where type like '" + this.txtBoxSearchCitizenPendingRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
