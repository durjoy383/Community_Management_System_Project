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
using System.Data.Sql;

namespace CommunityServiceManagement
{
    public partial class Login : MetroForm
    {
        private string nID;
        Home h; CitizenRegistration cr;
        string title;//ForgotPassword fp1;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        public Login()
        {

            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Login(Home h)
        {
            //MessageBox.Show("dsd");
            InitializeComponent();
            this.h = h;
            this.Da = new DataAccess();
        }

        /*public Login(ForgotPassword fp1,Home h)
        {

            InitializeComponent();
            this.fp1 =fp1;
            this.h = h;
            
        }*/



        public Login(CitizenRegistration cr, Home h)
        {

            InitializeComponent();
            this.cr = cr;
            this.h = h;
            this.Da = new DataAccess();
        }

        private void BtnLoginLogin_Click(object sender, EventArgs e)
        {
            string sql = @"select category from login where nid='" + this.txtboxNidLogin.Text + "' and password='" + this.txtBoxPasswordLogin.Text + "';";

            this.Ds = this.Da.ExecuteQuery(sql);
            title = this.Ds.Tables[0].Rows[0]["category"].ToString();




            try
            {
                if (title == "citizen")
                {

                    MessageBox.Show("Login Approved");
                    CitizenHome ch = new CitizenHome(this,this.txtboxNidLogin.Text);

                    ch.Visible = true;
                    this.Visible = false;

                    txtboxNidLogin.Text = "";
                    txtBoxPasswordLogin.Text = "";
                    


                }

                else if (title == "citycorp")
                {
                    MessageBox.Show("Login Approved");
                    AuthorityHome ah = new AuthorityHome(this);
                    ah.Visible = true;
                    this.Visible = false;

                    txtboxNidLogin.Text = "";
                    txtBoxPasswordLogin.Text = "";
                }

                else if (title == "police")
                {
                    MessageBox.Show("Login Approved");
                    PoliceHome ph = new PoliceHome(this);
                    ph.Visible = true;
                    this.Visible = false;

                    txtboxNidLogin.Text = "";
                    txtBoxPasswordLogin.Text = "";
                }
                else
                {
                    MessageBox.Show("Login Declined");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void BtnBackLogin_Click(object sender, EventArgs e)
        {
            this.h.Visible = true;
            this.Visible = false;
        }

        private void LblForgotPasswordLogin_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword(this,h);
            fp.Visible = true;
            this.Visible = false;
        }
    }
}
                     


                    
     
