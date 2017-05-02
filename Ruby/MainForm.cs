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

            string connetionString = null;
            string sql = null;
            connetionString = "Data Source =.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Menaxhimi.mdf;Integrated Security = True; User Instance = True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "INSERT INTO [dbo].[Malli] ([Emri], [Cmimi], [Data]) VALUES (@Emri,@Cmimi,@Data)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Emri", Convert.ToString(cmbMalli.SelectedValue));
                    cmd.Parameters.AddWithValue("@Cmimi",  Convert.ToInt32(txtCmimi.Text));
                    cmd.Parameters.AddWithValue("@Data", dtpData.Value.ToShortDateString());
                    
                    MessageBox.Show("Row inserted !! ");
                    cmd.ExecuteNonQuery();
                }
            }



        }
    }
}
