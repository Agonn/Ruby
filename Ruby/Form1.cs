using System;
using System.Windows.Forms;

namespace Ruby
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Mbylli te gjitha threads.
        }
    }
}
