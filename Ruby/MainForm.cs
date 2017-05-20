using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Ruby
{
    public partial class Form : MetroForm

    {
        #region Initialization
        public Form()
        {

            InitializeComponent();
            dtpData.Value = DateTime.Today.AddDays(-1); //Yesterday for Historia


            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string queryPerdgvShitja = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";

            string queryPerdgvFurdeSot = "SELECT * FROM TblFurde WHERE DATEDIFF(day, TblFurde.Data_blerjes , GETDATE()) = 0";

            SqlCommand objKomanda2 = new SqlCommand(queryPerdgvShitja, objKonektimi);
            SqlDataAdapter objAdapteri2 = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();
            objAdapteri2.Fill(_Shenimet);
            dgvShitja.DataSource = _Shenimet.Tables[0];

            SqlCommand objKomandaFurde = new SqlCommand(queryPerdgvFurdeSot, objKonektimi);
            SqlDataAdapter objAdapteriFurde = new SqlDataAdapter(objKomandaFurde);
            DataSet Furde = new DataSet();
            objAdapteriFurde.Fill(Furde);
            dgvFurde.DataSource = Furde.Tables[0];


            //QUERY NE FILLIM TE INICIALIZIMIT (ME PROVU ME HEK NESE NUK OST I NEVOJSHEM)
            try
            {
                //SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1
                //test AAB
                string QueryPerdgvHistoriaDje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1";
                SqlCommand objKomanda3 = new SqlCommand(QueryPerdgvHistoriaDje, objKonektimi);
                objKonektimi.Open();
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());

                SqlDataAdapter objAdapteri = new SqlDataAdapter(QueryPerdgvHistoriaDje, objKonektimi);
                DataSet Historia = new DataSet();
                objAdapteri.Fill(Historia);
                dgvHistoria.DataSource = Historia.Tables[0];
            
                
            }
            catch (Exception)
            {
                // MessageBox.Show("Nuk ka shitje per kete date"); //placeholder!
                lblHistoriaShitje.Text = "N/A";
            }
            finally
            {
                objKonektimi.Close();
            }

        }
#endregion





        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rubyDBDataSet3.TblShpenzimet' table. You can move, or remove it, as needed.
            this.tblShpenzimetTableAdapter.Fill(this.rubyDBDataSet3.TblShpenzimet);
            this.tblMalliTableAdapter1.Fill(this.rubyDBDataSet_Malli.TblMalli);
            this.tblFurdeTableAdapter.Fill(this.rubyDBDataSet_furde.TblFurde);
            this.tblMalliTableAdapter.Fill(this.rubyDBDataSet1.TblMalli);
        }

        //Ta Mshel formen
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login objforma1 = new Login();
            //this.Hide();
            //objforma1.Show(); 
            //Fix this to completly close app.

            this.Close(); //temporarily use this
        }

        #region Funksionet per Date Query


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

        string FunksioniPerFurde(string data)
        {
            //Funksioni i cili e ndan Stringun
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //Stringu i Querit qe bohet si perfundim
            string Query = "Select * from TblFurde Where Data_blerjes >= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 00:00:00' AND Data_blerjes <= '" + DataSakt[0] + "-" + DataSakt[3] + "-" + DataSakt[6] + " 23:59:59'";

            //Funksioni kthen qet string
            return Query;
        }

        #endregion


        //Funksioni qe e mer daten edhe bon query per me qit qat dat ne DGV
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
                double mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                objAdapteri.Fill(Shenimet);
                dgvHistoria.DataSource = Shenimet.Tables[0];
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                
            }
            catch (Exception)
            {
                lblHistoriaShitje.Text = "N/A";
                dgvHistoria.Visible = false; //Not visible i there is no data in gridview
            }
            finally
            {
                objKonektimi.Close();
            }
        }

        //Funksioni qe shton te dhanat te Pjesa e Shitjeve(kryesore)
        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 
            string queryPerInsertim = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtbmPershkrimi.Text + "')";

            string queryPerShitje = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";

            SqlCommand objKomanda = new SqlCommand(queryPerInsertim, objKonektimi);

            SqlCommand objKomanda2 = new SqlCommand(queryPerShitje, objKonektimi);
            SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();

            try
            {
                objKonektimi.Open();

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

        //E mbush me te dhana DGV Malli
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblMalliTableAdapter.FillBy(this.rubyDBDataSet1.TblMalli);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Shton Furde te tabela e furdeve
        private void btShtoFurde_Click(object sender, EventArgs e) //Shto Furde buttoni per query 
        {

            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            double total = double.Parse(txtSasiaFurde.Text) * double.Parse(txtGramFurde.Text);

            string queryPerInsertimFurde = "insert into dbo.tblFurde(Sasia_gr_furde,Cmimi_per_gr_furde,Cmimi_total_furde,Data_blerjes,Pershkrimi) values('" + float.Parse(txtSasiaFurde.Text) + "','" + float.Parse(txtGramFurde.Text) + "','" + total.ToString() + "','" + dtpFurde.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtPershkrimiFurde.Text + "')";

            string queryPerShfaqjeFurde = "SELECT * FROM TblFurde WHERE DATEDIFF(day, TblFurde.Data_blerjes , GETDATE()) = 0";


            SqlCommand objKomanda = new SqlCommand(queryPerInsertimFurde, objKonektimi);
            SqlCommand objKomanda2 = new SqlCommand(queryPerShfaqjeFurde, objKonektimi);

            SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();

            try
            {
                objKonektimi.Open();


                int numri_reshtave = objKomanda.ExecuteNonQuery();

                objAdapteri.Fill(_Shenimet);
                dgvFurde.DataSource = _Shenimet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objKonektimi.Close();
                txtSasiaFurde.Clear();
                txtGramFurde.Clear();
                txtPershkrimiFurde.Clear();
            }

         

        }


        //I shton Shpenzimet ne Databaze edhe i paraqet ne tabele
        private void btShtoShpenzime_Click(object sender, EventArgs e) //Query per shpenzime
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string queryPerInsertimShpenzime = "insert into TblShpenzimet(Rryma_fat,Uji_fat,Tatimi_fat,Data_fatures,Pershkrimi) values ('" + float.Parse(txtShpenzimeRryma.Text) + "','" + float.Parse(txtShpenzimeUji.Text) + "','" + float.Parse(txtShpenzimeTatimi.Text) + "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtShpenzimePershkrimi.Text + "')";

            string queryPerShfaqjeShpenzime = "SELECT * FROM TblShpenzimet";

            SqlCommand objKomanda = new SqlCommand(queryPerInsertimShpenzime, objKonektimi);
            SqlCommand objKomanda2 = new SqlCommand(queryPerShfaqjeShpenzime, objKonektimi);

            SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();

            try
            {
                objKonektimi.Open();


                int numri_reshtave = objKomanda.ExecuteNonQuery();
                objAdapteri.Fill(_Shenimet);
                dgvShpenzimet.DataSource = _Shenimet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objKonektimi.Close();
                txtShpenzimeRryma.Clear();
                txtShpenzimeUji.Clear();
                txtShpenzimeTatimi.Clear();
                txtShpenzimePershkrimi.Clear();
            }
        }


        //Me mar daten per furde edhe me e paraqit ne tabele si histori
        private void dtpFurde_ValueChanged(object sender, EventArgs e)
        {
            dgvFurde.Visible = true; //Grid visible if there's data

            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string QueryPerFurde = FunksioniPerFurde(dtpFurde.Value.ToString("yyyy - MM - dd  HH: mm:ss"));

            SqlCommand objKomanda3 = new SqlCommand(QueryPerFurde, objKonektimi);
            objKonektimi.Open();
            SqlDataAdapter objAdapteri = new SqlDataAdapter(QueryPerFurde, objKonektimi);
            DataSet Shenimet = new DataSet();

            try
            {
                double mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                objAdapteri.Fill(Shenimet);
                dgvFurde.DataSource = Shenimet.Tables[0];
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                
            }
            catch (Exception)
            {
                dgvFurde.Visible = false;
            }
            finally
            {
                objKonektimi.Close();
            }

        }


        //Nuk ja ndova menden qka po bon hala qesej
        private void historikuToolStripMenuItem_Click(object sender, EventArgs e) //Backup database to .bak
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            
            objKonektimi.Open();

            string DatabaseName = Application.StartupPath + @"\RubyDB.mdf";

            SqlCommand BackupDB = new SqlCommand("BACKUP DATABASE [" + DatabaseName + "] to DISK='Desktop\\RubyDatabase.bak' ", objKonektimi);


            try
            {
                BackupDB.ExecuteNonQuery();
                MessageBox.Show("Databaza u ruajt me sukses.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("'" + Ex.ToString() + "'");
            }
            finally
            {
                objKonektimi.Close();
            }
                
        }
    }
}
