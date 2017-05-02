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





        }
    }
}
