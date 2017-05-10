using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;
using Ruby.Properties;

namespace Ruby
{
    public partial class Form : MetroForm

    {
        #region Initialization
        public Form()
        {

            InitializeComponent();
            cmbStatistika.SelectedIndex = 0; //Statistika data te jete SOT.
            dtpData.Value = DateTime.Today.AddDays(-1); //Yesterday for Historia

            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string queryPerdgvShitja = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";

            SqlCommand objKomanda2 = new SqlCommand(queryPerdgvShitja, objKonektimi);



            SqlDataAdapter objAdapteri2 = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();
            objAdapteri2.Fill(_Shenimet);
            dgvShitja.DataSource = _Shenimet.Tables[0];

            try
            {
                //SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1

                string QueryPerdgvHistoriaDje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1";
                SqlCommand objKomanda3 = new SqlCommand(QueryPerdgvHistoriaDje, objKonektimi);
                objKonektimi.Open();
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());

                SqlDataAdapter objAdapteri = new SqlDataAdapter(QueryPerdgvHistoriaDje, objKonektimi);
                DataSet Historia = new DataSet();
                objAdapteri.Fill(Historia);
                dgvHistoria.DataSource = Historia.Tables[0];
            
                objKonektimi.Close();
            }
            catch (Exception)
            {
                // MessageBox.Show("Nuk ka shitje per kete date"); //placeholder!
                lblHistoriaShitje.Text = "N/A";
            }

        }
#endregion
        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubyDBDataSet1.TblMalli' table. You can move, or remove it, as needed.
            this.tblMalliTableAdapter.Fill(this.rubyDBDataSet1.TblMalli);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login objforma1 = new Login();
            //this.Hide();
            //objforma1.Show(); 
            //Fix this to completly close app.

            this.Close(); //temporarily use this
        }

        #region Query function


        string FunksioniPerDate(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select * from TblMalli Where Data_Shitjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_Shitjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }

        string FunksioniPerShum(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select SUM(Malli_Cmimi) from TblMalli Where Data_Shitjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_Shitjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }
        #endregion


        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

            dgvHistoria.Visible = true; //Grid visible if there's data
            string theDate = dtpData.Value.ToShortDateString();
            
            lblDataSot.Text = theDate.ToString();
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            try
            {
               
                string queryPerHistorialbl = FunksioniPerShum(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));

                string queryPerdgvHistoria = FunksioniPerDate(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));


                SqlCommand objKomanda3 = new SqlCommand(queryPerHistorialbl, objKonektimi);
                objKonektimi.Open();
                SqlDataAdapter objAdapteri = new SqlDataAdapter(queryPerdgvHistoria, objKonektimi);
                DataSet Shenimet = new DataSet();
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                objAdapteri.Fill(Shenimet);
                dgvHistoria.DataSource = Shenimet.Tables[0];
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                objKonektimi.Close();
            }
            catch (Exception)
            {
                lblHistoriaShitje.Text = "N/A";
                dgvHistoria.Visible = false; //Not visible i there is no data in gridview
            }
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            
            try
            {
                //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 

                string queryPerInsertim = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtbmPershkrimi.Text + "')";
                SqlCommand objKomanda = new SqlCommand(queryPerInsertim, objKonektimi);

                string queryPerShitje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";   
                SqlCommand objKomanda2 = new SqlCommand(queryPerShitje, objKonektimi);
                SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
                DataSet _Shenimet = new DataSet();
                
                objKonektimi.Open();

                int numri = 0;
                numri++;
                int numri_reshtave = objKomanda.ExecuteNonQuery();     
                lblmShenimet.Text= "Numri i afektuar i rreshtave eshte : " + numri_reshtave.ToString();

                objAdapteri.Fill(_Shenimet);
                dgvShitja.DataSource = _Shenimet.Tables[0];

                //Clear input after inserting to db
                txtCmimi.Clear();
                txtbmPershkrimi.Clear();
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblMalliTableAdapter.FillBy(this.rubyDBDataSet1.TblMalli);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
