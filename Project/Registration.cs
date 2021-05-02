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
    public partial class Registration : MetroForm
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        Home h;
        public Registration(Home h)
        {
            InitializeComponent();
            this.h = h;
            this.Da = new DataAccess();
        }

        private void BtnBackRegistration_Click(object sender, EventArgs e)
        {
           
            this.h.Visible = true;
            this.Visible = false;
        }

        

        private void BtnNextRegistration_Click(object sender, EventArgs e)
        {
            string nid = this.txtNIDRegistration.Text;  string password = this.txtPasswordRegistration.Text;  string confirmpassword = this.txtboxConfirmPasswordRegistration.Text;
            if (nid==""|| password=="" || confirmpassword=="")
            {
                MessageBox.Show("You Must Fill up");
            }
            else
            {
                if (this.txtPasswordRegistration.Text.ToString() == this.txtboxConfirmPasswordRegistration.Text.ToString())
                {
                    try
                    {

                        string sql = @"insert into login values (" + this.txtNIDRegistration.Text + ", '" + this.txtPasswordRegistration.Text + "', 'citizen');";
                        int count = this.Da.ExecuteUpdateQuery(sql);


                        CitizenRegistration cr = new CitizenRegistration(this, h);
                        cr.Visible = true;
                        this.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception Occured:" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Password Not Matched");
                }
            }
        }
    }
}
