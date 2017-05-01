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


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Mbylli te gjitha threads.
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //click to maximize from notification icon
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            
         


        }
    }
}
