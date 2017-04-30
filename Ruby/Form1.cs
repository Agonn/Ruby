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
        //Mi mbyll te gjitha threads kur e ndalim app ne X - spo funksionon komplet.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
