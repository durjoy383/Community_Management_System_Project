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
    public partial class ForgotPassword : MetroForm
    {

        string name;Login l1;Home h;
        

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        public ForgotPassword(Login l1,Home h)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.h = h;
            this.l1 = l1;
            
        }

        

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.pnlForgotPassword1.Visible = true;
            this.pnlForgotPassword2.Visible = false;
        }

        

        private void BtnVerifyForgotPassword_Click(object sender, EventArgs e)
        {
            string sql = @"select name from citizenregistration where nid='" + this.txtboxNidForgotPassword.Text.ToString() + "';";
            this.Ds = this.Da.ExecuteQuery(sql);
            name = this.Ds.Tables[0].Rows[0]["name"].ToString();
            string name1 = this.txtboxNameForgotPassword2.Text.ToString();
            if (name==name1)
            {
                 
                MessageBox.Show("Matched");
                string sql1 = @"update login set nid = '" + this.txtboxNidForgotPassword.Text + "',password = '" + this.txtboxPaswordForgotPassword.Text + "',category = 'citizen' where nid='" + this.txtboxNidForgotPassword.Text + "';";
                this.Da.ExecuteUpdateQuery(sql1);
                MessageBox.Show("Reset Done");
                this.txtboxNameForgotPassword2.Text = "";
            }
            else
            {
                
                MessageBox.Show("Not matched");
            }
        }

        private void BtnResetForgotPassword_Click(object sender, EventArgs e)
        {
            string nid = this.txtboxNidForgotPassword.Text;string password = this.txtboxPaswordForgotPassword.Text;
            string cpassword = this.txtboxConfirmPasswordForgotPassword.Text;


             if (nid == "" || password == "" || cpassword == "")
            {
                MessageBox.Show("You Must Fill Up");
            }
            else if (this.txtboxPaswordForgotPassword.Text.ToString() == this.txtboxConfirmPasswordForgotPassword.Text.ToString())
            {
                this.pnlForgotPassword2.Visible = true;
                this.pnlForgotPassword1.Visible = false;
            }
            
            else
            {
                MessageBox.Show("Password Not Matched");
            }
            

            
        }

        

        private void BtnLoginForgotPassword_Click(object sender, EventArgs e)
        {
            //Login l1 = new Login(this, h);
            this.l1.Visible = true;
            this.Visible = false;
        }
    }
}
