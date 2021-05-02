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
    public partial class CitizenRegistration : MetroForm
    {
        Registration r;

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        private Home h { set; get; }
        public CitizenRegistration(Registration r,Home h)
        {
            InitializeComponent();
            this.r = r;
            this.h = h;
            this.Da = new DataAccess();
        }

        private void BtnBackCitizenRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Must Complete Registration");
            //this.r.Visible = true;
            //this.Visible = false;
        }

        private void BtnConfirmCitizenRegistration_Click(object sender, EventArgs e)
        {
            
            string nid = this.txtboxNidCitizenRegistration.Text;string name = this.txtboxNameCitizen.Text;string phone = this.txtboxPhoneCitizen.Text;
            string dob = this.dtpCitizen.Text;string email = this.txtboxEmailCitizen.Text;string address = this.txtboxAddressCitizen.Text;
            string gender = this.cmbBoxCitizenRegistration.Text;string bloodgroup = this.txtboxBloodGroupCitizen.Text;
            if(nid==""|| name == "" || phone == "" || dob == "" ||email == "" ||address == "" ||gender == "" ||bloodgroup == "")
            {
                MessageBox.Show("You must Fill Up");

            }
            else
            {
                try
                {
                    string sql = @"insert into citizenregistration values (" + this.txtboxNidCitizenRegistration.Text + ", '" + this.txtboxNameCitizen.Text + "', '" + this.txtboxPhoneCitizen.Text + "','" + this.dtpCitizen.Text + "','" + this.txtboxEmailCitizen.Text + "','" + this.txtboxAddressCitizen.Text + "','" + this.cmbBoxCitizenRegistration.Text + "','" + this.txtboxBloodGroupCitizen.Text + "');";
                    int count = this.Da.ExecuteUpdateQuery(sql);

                    MessageBox.Show("Are you Sure?");
                    Login l1 = new Login(this, h);
                    l1.Visible = true;
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception:" + ex);
                }
            }
            
        }
    }
}
