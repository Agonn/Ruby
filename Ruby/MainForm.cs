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
        public Form()
        {
            InitializeComponent();
            cmbStatistika.SelectedIndex = 0; //Statistika data te jete SOT.
            dtpData.Value = DateTime.Today.AddDays(-1); //Yesterday for Historia

            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);

            string Query4 = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";

            SqlCommand objKomanda2 = new SqlCommand(Query4, objKonektimi);

            //Veq deshta me pa formatin e dates
           // lblmShenimet.Text = dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss");



            SqlDataAdapter objAdapteri2 = new SqlDataAdapter(objKomanda2);
            DataSet _Shenimet = new DataSet();
            objAdapteri2.Fill(_Shenimet);
            dgvShitja.DataSource = _Shenimet.Tables[0];

            try
            {
                //SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1

                string query4 = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 1";
                SqlCommand objKomanda3 = new SqlCommand(query4, objKonektimi);
                objKonektimi.Open();
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());

                SqlDataAdapter objAdapteri = new SqlDataAdapter(query4, objKonektimi);
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

        string FunksioniPerDate(string data)
        {

            //        string myString = "12,Apple,20";
            //         string[] subStrings = myString.Split(',');

            // 2017-05-08 00:00:00
            //string[] DataSubString = data.Split('-');
            //string Dita = DataSubString[2];
            // string[]  ditaskat = Dita.Split(' ');

            // string strings = "4,6,8\n9,4";
            //string[] split = strings.Split(new Char[] { ',', '\n' });

            // 0    1  2  3
            //2017-05-08 00:00:00
            string[] DataSakt = data.Split(new char[] { '-', ' ' });

            //string QueryTest = "Select * from TblMalli Where Data_Shitjes >= '2017-05-09 00:00:00' AND Data_Shitjes <= '2017-05-09 23:59:59' ";

            lblmShenimet.Text = DataSakt[3];

            string Query = "Select * from TblMalli Where Data_Shitjes >= '"+DataSakt[0]+ "-" + DataSakt[3]+ "-" + DataSakt[6] +" 00:00:00' AND Data_Shitjes <= '"+ DataSakt[0]+"-" + DataSakt[3]+ "-" + DataSakt[6]+" 23:59:59'";

            return Query;
        }


        //QETU KOM ME PUNU PER ME BO FUNKSIONIN
        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtpData.Value.ToShortDateString();
            lblDataSot.Text = theDate.ToString();
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
     

            try
            {


                //Duhet me i paraqit te gjith historin e qasej dite qe po e zgjedhim nga dgv-ja
                //SELECT  *
                //   FROM Product_sales
                //   WHERE From_date >= '2013-01-03' AND
                //   To_date <= '2013-01-09'

               

                //Ta paraqet shumen ne Euro te labela
                string query3 = "select SUM(Malli_Cmimi) from TblMalli where Data_Shitjes='" + dtpData.Value.ToString("yyyy-MM-dd") + "'";
                //Duhet me i paraqit te gjith historin e qasej dite qe po e zgjedhim nga dgv-ja
                string query4 = "select * from TblMalli where Data_Shitjes='" + dtpData.Value.ToString("yyyy-MM-dd") + "'";

                string QueryTest = "Select * from TblMalli Where Data_Shitjes >= '2017-05-09 00:00:00' AND Data_Shitjes <= '2017-05-09 23:59:59' ";

                string QueryMeFunksion = FunksioniPerDate(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));

               // lblmShenimet.Text = FunksioniPerDate(dtpData.Value.ToString("yyyy - MM - dd  HH: mm:ss"));


                SqlDataAdapter objAdapteri = new SqlDataAdapter(QueryMeFunksion, objKonektimi);
                DataSet Shenimet = new DataSet();

                SqlCommand objKomanda3 = new SqlCommand(query3, objKonektimi);

                objKonektimi.Open();

                
                objAdapteri.Fill(Shenimet);
                dgvHistoria.DataSource = Shenimet.Tables[0];
                int mySum = Convert.ToInt32(objKomanda3.ExecuteScalar());
                lblHistoriaShitje.Text = mySum.ToString() + "€";
                
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


        private void btnShto_Click_1(object sender, EventArgs e)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            
            try
            {
                //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 

                string Query2 = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('" + cmbMalli.SelectedItem.ToString() + "','" + float.Parse(txtCmimi.Text) + "','" + dtpShitje.Value.ToString("yyyy-MM-dd  HH:mm:ss") + "','" + txtbmPershkrimi.Text + "')";
                SqlCommand objKomanda = new SqlCommand(Query2, objKonektimi);

                string Query3 = "SELECT * FROM TblMalli WHERE DATEDIFF(day, TblMalli.Data_Shitjes , GETDATE()) = 0";   
                SqlCommand objKomanda2 = new SqlCommand(Query3, objKonektimi);
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

        private void tbShitja_Click(object sender, EventArgs e)
        {

        }

        private void tbStatistika_Click(object sender, EventArgs e)
        {

        }
    }
}
