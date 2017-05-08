using System;
using System.Windows.Forms;
using MetroFramework.Forms;
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

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubyDBDataSet1.TblMalli' table. You can move, or remove it, as needed.
            this.tblMalliTableAdapter.Fill(this.rubyDBDataSet1.TblMalli);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit(); //Me ndru me login-form 
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtpData.Value.ToShortDateString();
            lblDataSot.Text = theDate.ToString(); 

            //SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            //string query3 = "SELECT SUM(Malli_Cmimi) from TblMalli WHERE Data_Shitjes='" + dtpData.Value + "'";

            //SqlCommand objKomanda3 = new SqlCommand(query3, objKonektimi);
            //objKonektimi.Open();
            //lblHistoriaShitje.Text = objKomanda3.ExecuteScalar().ToString();
            //objKonektimi.Close();
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 
            // string Query = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('unaze','33.5','2017-05-02','eh')";

            string Query2 = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpData.Value.ToString("yyyy-MM-dd") + "','" + txtbmPershkrimi.Text + "')";
            SqlCommand objKomanda = new SqlCommand(Query2, objKonektimi);         
            
            string Query3 = "select *from TblMalli";
            SqlCommand objKomanda2 = new SqlCommand(Query3, objKonektimi);
            
            int numri = 0;
            //comboBox1.SelectedItem.ToString() 
            SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();
            try
            {
                numri++;
                objKonektimi.Open();
                int numri_reshtave = objKomanda.ExecuteNonQuery();
                txtmShenimet.Text = "Numri i afektuar i rreshtave eshte : " + numri_reshtave.ToString();
                lblmShenimet.Text= "Numri i afektuar i rreshtave eshte : " + numri_reshtave.ToString();
                objAdapteri.Fill(_Shenimet);
                dgvShitja.DataSource = _Shenimet.Tables[0];
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

        private void tbHistoria_Click(object sender, EventArgs e)
        {

        }


        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


        }
    }
}
