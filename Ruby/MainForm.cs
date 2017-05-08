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

            try
            {
                SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
                string query3 = "select SUM(Malli_Cmimi) from TblMalli where Data_Shitjes='" + dtpData.Value.ToString("yyyy-MM-dd") + "'";
                SqlCommand objKomanda3 = new SqlCommand(query3, objKonektimi);
                objKonektimi.Open();
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                objKonektimi.Close();
            }
            catch (Exception)
            {

               // MessageBox.Show("Nuk ka shitje per kete date"); //placeholder!
                lblHistoriaShitje.Text = "N/A";
            }
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

           
            try
            {
                //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 

                string Query2 = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpData.Value.ToString("yyyy-MM-dd") + "','" + txtbmPershkrimi.Text + "')";
                SqlCommand objKomanda = new SqlCommand(Query2, objKonektimi);

                string Query3 = "select *from TblMalli";
                SqlCommand objKomanda2 = new SqlCommand(Query3, objKonektimi);

                int numri = 0;
                //comboBox1.SelectedItem.ToString() 
                SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
                DataSet _Shenimet = new DataSet();
                numri++;
                objKonektimi.Open();
                int numri_reshtave = objKomanda.ExecuteNonQuery();
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
