using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using MaterialSkin.Controls;
using MetroFramework.Forms;

namespace Ruby
{
    public partial class Form : MetroForm

    {
        public Form()
        {
            InitializeComponent();

        }





        private void btnShto_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menaxhimiDataSet1.Malli' table. You can move, or remove it, as needed.
            this.malliTableAdapter.Fill(this.menaxhimiDataSet1.Malli);
            // TODO: This line of code loads data into the 'menaxhimiDataSet1.Malli' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'menaxhimiDataSet.Malli' table. You can move, or remove it, as needed.

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtpData.Value.ToShortDateString();

            lblDataSot.Text = theDate.ToString();

        }
        //Data Source =.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Menaxhimi.mdf;Integrated Security = True; User Instance = True
        private void btnShto_Click_1(object sender, EventArgs e)
        {

            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            //Formati DataTime DATETIME values in 'YYYY-MM-DD HH:MM:SS' 
            string Query = "insert into dbo.tblMalli(Malli_Emri,Malli_Cmimi,Data_Shitjes,Pershkrimi) values('unaze','33.5','2017-05-02','eh')";
            SqlCommand objKomanda = new SqlCommand(Query, objKonektimi);

            try
            {
                objKonektimi.Open();
                objKomanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                objKonektimi.Close();
                // objKonektimi.Close();
            }



        }
    }
}
