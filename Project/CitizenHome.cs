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


    public partial class CitizenHome : MetroForm
    {
        Login l1;
        string nID;

        
        public CitizenHome(Login l1,string id)
        {
            InitializeComponent();
            this.l1 = l1;
            this.nID = id;
        }

        
        private void BtnLogoutCitizenHome_Click(object sender, EventArgs e)
        {
            
            this.l1.Visible = true;
            this.Visible = false;

        }

        private void BtnCheckReqCitizenHome_Click(object sender, EventArgs e)
        {
            CitizenPendingRequests cpr = new CitizenPendingRequests(this,this.nID);
            cpr.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckAcceptReqCitizenHome_Click(object sender, EventArgs e)
        {
            CitizenAcceptedRequests car = new CitizenAcceptedRequests(this,this.nID);
            car.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckDeclinedRequestCitizenHome_Click(object sender, EventArgs e)
        {
            CitizenDeclinedRequest cdr = new CitizenDeclinedRequest(this,this.nID);
            cdr.Visible = true;
            this.Visible = false;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ApplyForm af = new ApplyForm(this);
            af.Visible = true;
            this.Visible = false;
        }
    }
}
