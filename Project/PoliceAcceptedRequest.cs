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
    public partial class PoliceAcceptedRequest : MetroForm
    {
        PoliceHome ph;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public PoliceAcceptedRequest(PoliceHome ph)
        {
            InitializeComponent();
            this.ph = ph;

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void BtnHomePoliceAcceptedRequest_Click(object sender, EventArgs e)
        {
            this.ph.Visible = true;
            this.Visible = false;
        }

        private void PopulateGridView(string sql = "select * from acceptrequest where type='police clearance';;")
        {
            this.dgviewPoliceAccepted.AutoGenerateColumns = false;

            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgviewPoliceAccepted.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void BtnsearchPoliceAcceptedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchPoliceAcceptedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchPoliceAcceptedRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchPoliceAcceptedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
