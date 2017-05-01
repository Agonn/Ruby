using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Ruby
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();
        }
        private void ImportStatusForm_Resize(object sender, EventArgs e) //Nese showintaskbar false
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'menaxhimiDBDataSet12.tblMalli' table. You can move, or remove it, as needed.
            this.tblMalliTableAdapter.Fill(this.menaxhimiDBDataSet12.tblMalli);
            // TODO: This line of code loads data into the 'menaxhimiDBDataSet12.tblMalli' table. You can move, or remove it, as needed.
            this.tblMalliTableAdapter.Fill(this.menaxhimiDBDataSet12.tblMalli);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Mbylli te gjitha threads.
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //click to maximize from notification icon
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            
            string Konektimi = Parametrat._KonektimiDB;
            SqlConnection objKonektimi = new SqlConnection(Konektimi);
            string query = "INSERT INTO [dbo].[tblMalli] ( Emri_Mallit, Cmimi_Mallit, Data_Shitjes) VALUES (" + cmbMalli.GetItemText(cmbMalli.SelectedItem)+","+ txtCmimi.Text +",'"+dtpData.Value.ToShortDateString()+"')";





            SqlCommand objKomanda = new SqlCommand(query, objKonektimi);

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
            }


        }
    }
}
