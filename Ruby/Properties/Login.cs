using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruby.Properties
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 objforma1 = new Form1();

           
            //E mshef formen e login-it
            this.Hide();
            //E Hap formen Kryesore
            objforma1.Show();
        }
    }
}
