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
    public partial class Home : MetroForm
    {
        
        public Home()
        {
            InitializeComponent();
            
        }

        



        private void BtnLoginHome_Click(object sender, EventArgs e)
        {
            Login l1 = new Login(this);
            l1.Visible = true;
            this.Visible = false;
        }

        private void BtnRegistrationHome_Click(object sender, EventArgs e)
        {
            Registration r = new Registration(this);
            r.Visible = true;
            this.Visible = false;
        }

        private void BtnExitHome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
