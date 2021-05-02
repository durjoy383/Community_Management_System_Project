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
    
    public partial class ApplyForm : MetroForm
    {
        CitizenHome ch;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        

        
        public ApplyForm(CitizenHome ch)
        {
            InitializeComponent();
            this.ch = ch;
            this.Da = new DataAccess();
        }

        private void BtnBackApplyForBc_Click(object sender, EventArgs e)
        {
            
            this.ch.Visible = true;
            this.Visible = false;
        }

        private void BtnConfirmApplyForBc_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"insert into pendingrequest values (" + this.txtboxNidBirtchCertificate.Text + ", '" + this.txtboxNameApplyForBc.Text + "', '" + this.txtboxPhoneApplyForBc.Text + "','" + this.dtpApplyForBc.Text + "','" + this.txtboxEmailApplyForBc.Text + "','" + this.txtboxAddressApplyForBc.Text + "','" + this.cmbBoxCitizenApply.Text + "','" + this.txtboxBloodGroupApplyForBc.Text + "','" +this.cmbboxTypeApplyForm.Text+"');";
                int count = this.Da.ExecuteUpdateQuery(sql);

                MessageBox.Show("Application Submitted");
                this.txtboxNidBirtchCertificate.Text = "";
                this.txtboxNameApplyForBc.Text = "";
                this.txtboxPhoneApplyForBc.Text = "";
                this.dtpApplyForBc.Text = "";
                this.txtboxEmailApplyForBc.Text = "";
                this.txtboxAddressApplyForBc.Text = "";
                this.cmbBoxCitizenApply.Text = "";
                this.txtboxBloodGroupApplyForBc.Text = "";
                this.cmbboxTypeApplyForm.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
            }
        }
    }
}
