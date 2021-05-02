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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CommunityServiceManagement
{
    
    public partial class CitizenAcceptedRequests : MetroForm
    {
        CitizenHome ch;Login l1;
        string nID;
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        public CitizenAcceptedRequests(CitizenHome ch,string id)
        {
            InitializeComponent();
            this.ch = ch;
            this.nID=id;

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from acceptrequest ")
        {
            //sql = sql + "where nid=" + nID;
            string sql1 = "select * from acceptrequest where nid="+this.nID+";"; 
            this.dgviewCitizenAccepted.AutoGenerateColumns = false;

            try
            {
                this.Ds = this.Da.ExecuteQuery(sql1);
                this.dgviewCitizenAccepted.DataSource = this.Ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void BtnHomeCitizenAcceptedRequest_Click(object sender, EventArgs e)
        {
           
            this.ch.Visible = true;
            this.Visible = false;
        }

        private void BtnsearchCitizenAcceptedRequest_Click(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchAuthorityCitizenRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtBoxSearchAuthorityCitizenRequest_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from acceptrequest where type like '" + this.txtBoxSearchAuthorityCitizenRequest.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        List list = new List(List.UNORDERED);
                        list.Add(this.txtboxNidAuthorityPending.Text.ToString());
                        list.Add(this.txtboxNameApplyForBc.Text.ToString());
                        list.Add(this.txtboxPhoneApplyForBc.Text.ToString());
                        list.Add(this.dtpApplyForBc.Text.ToString());
                        list.Add(this.txtboxEmailApplyForBc.Text.ToString());
                        list.Add(this.txtboxAddressApplyForBc.Text.ToString());
                        list.Add(this.txtboxGenderApplyForBc.Text.ToString());
                        list.Add(this.txtboxBloodGroupApplyForBc.Text.ToString());
                        list.Add(this.txtBoxCitizenAcceptedType.Text.ToString());
                        doc.Add(list);
                        //doc.Add(new iTextSharp.text.)
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Exception " + ex);
                    }
                    finally
                    {

                        doc.Close();
                        this.txtboxNidAuthorityPending.Text = "";
                        this.txtboxNameApplyForBc.Text= "";
                        this.txtboxPhoneApplyForBc.Text = "";
                        this.dtpApplyForBc.Text = "";
                        this.txtboxEmailApplyForBc.Text = "";
                        this.txtboxAddressApplyForBc.Text = "";
                        this.txtboxGenderApplyForBc.Text = "";
                        this.txtboxBloodGroupApplyForBc.Text = "";
                        this.txtBoxCitizenAcceptedType.Text = "";

                    }
                }
            }
        }

        private void DgviewCitizenAccepted_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxNidAuthorityPending.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["nid"].Value.ToString();
            this.txtboxNameApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["name"].Value.ToString();
            this.txtboxPhoneApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["phone"].Value.ToString();
            this.dtpApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["dob"].Value.ToString();
            this.txtboxEmailApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["email"].Value.ToString();
            this.txtboxAddressApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["address"].Value.ToString();
            this.txtboxGenderApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["gender"].Value.ToString();
            this.txtboxBloodGroupApplyForBc.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtBoxCitizenAcceptedType.Text = this.dgviewCitizenAccepted.CurrentRow.Cells["type"].Value.ToString();
            MessageBox.Show("Data has been pushed from grid.");
        }
    }
}
