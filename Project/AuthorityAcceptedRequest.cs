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
    public partial class AuthorityAcceptedRequest : MetroForm
    {
        AuthorityHome ah;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public AuthorityAcceptedRequest(AuthorityHome ah)
        {
            InitializeComponent();
            this.ah = ah;
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from acceptrequest where type='birth certificate' or type='legacy certificate'or type='character certificate';;")
        {
            this.dgviewAuthorityAccepted.AutoGenerateColumns = false;

            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgviewAuthorityAccepted.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }
        private void BtnHomeAuthorityAcceptedRequest_Click(object sender, EventArgs e)
        {
            
            this.ah.Visible = true;
            this.Visible = false;
        }

        private void BtnsearchAuthorityAcceptedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchAuthorityAcceptedRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchAuthorityAcceptedRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchAuthorityAcceptedRequest.Text + "%';";
           this.PopulateGridView(sql);
        }
    }
}
