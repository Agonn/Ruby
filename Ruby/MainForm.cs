using System;
using System.Windows.Forms;
using MetroFramework.Forms;

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
            //VETEM PUNO ,MBARO DATABASE E KRJET QA KI

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dtpData.Value.ToShortDateString();

            lblDataSot.Text = theDate.ToString();

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
            metroTab.SelectedIndex = 0; ; //Switch te tab shitja 
        }
    }
}
