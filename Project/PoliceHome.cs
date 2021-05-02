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
    public partial class PoliceHome : MetroForm
    {
        Login l1;
        public PoliceHome(Login l1)
        {
            InitializeComponent();
            this.l1 = l1;
        }

        private void BtnLogoutPoliceHome_Click(object sender, EventArgs e)
        {
            this.l1.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckPendingPoliceHome_Click(object sender, EventArgs e)
        {
            PolicePendingRequest ppr = new PolicePendingRequest(this);
            ppr.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckAcceptedPoliceHome_Click(object sender, EventArgs e)
        {
            PoliceAcceptedRequest par = new PoliceAcceptedRequest(this);
            par.Visible = true;
            this.Visible = false;
        }

        private void BtnCheckDeclinedPoliceHome_Click(object sender, EventArgs e)
        {
            PoliceDeclinedRequest pcr = new PoliceDeclinedRequest(this);
            pcr.Visible = true;
            this.Visible = false;
        }
    }
}
