using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ruby
{
    public partial class Form : MetroForm

    {
        public Form()
        {
            InitializeComponent();
            cmbStatistika.SelectedIndex = 0; //Statistika data te jete SOT.

        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            //Main button

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit(); //Me ndru me login-form 
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtpData.Value.ToShortDateString();

            lblDataSot.Text = theDate.ToString(); //Convert daten ne string

        }



        private void btnShpenzime_Click(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlShpenzime.Visible = true;
            metroTab.SelectedIndex = 0; ; //Switch te tab shitja 
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            pnlShpenzime.Visible = false;
            //metroTab.SelectedIndex = 0; ; //Switch te tab shitja 
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 
             string Query = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('unaze','33.5','2017-05-02','eh')";
            string Query2 = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpData.Value.ToString("yyyy-MM-dd") + "','" + txtbmPershkrimi.Text + "')";
            SqlCommand objKomanda = new SqlCommand(Query2, objKonektimi);                                         //Malli_Emri             Cmimi                                     Data             formati dates                  Pershkrimi   
            int numri = 0;
            //comboBox1.SelectedItem.ToString() 
            try
            {
                numri++;
                objKonektimi.Open();
                int numri_reshtave = objKomanda.ExecuteNonQuery();
                txtmShenimet.Text = "Numri i afektuar i rreshtave eshte : " + numri_reshtave.ToString();
                lblmShenimet.Text= "Numri i afektuar i rreshtave eshte : " + numri_reshtave.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
            finally
            {

                objKonektimi.Close();

            }

        }

        private void txtbmPershkrimi_Click(object sender, EventArgs e)
        {

        }

        private void tbShitja_Click(object sender, EventArgs e)
        {

        }
    }
}
