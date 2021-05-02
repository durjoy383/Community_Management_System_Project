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

namespace CommunityServiceManagement
{
    public partial class AuthorityHome : MetroForm
    {
        Login l1;
        public AuthorityHome(Login l1)
        {
            InitializeComponent();
            this.l1 = l1;
        }

        private void BtnLogoutAuthorityHome_Click(object sender, EventArgs e)
        {
            
            this.l1.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckPendingAuthorityHome_Click(object sender, EventArgs e)
        {
            AuthorityPendingRequest apr = new AuthorityPendingRequest(this);
            apr.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckAcceptedAuthorityHome_Click(object sender, EventArgs e)
        {
            AuthorityAcceptedRequest aar = new AuthorityAcceptedRequest(this);
            aar.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckDeclinedAuthorityHome_Click(object sender, EventArgs e)
        {
            AuthorityDeclinedRequests adr = new AuthorityDeclinedRequests(this);
            adr.Visible = true;
            this.Visible = false;
        }
    }
}
