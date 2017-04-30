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
    public partial class Login : System.Windows.Forms.Form
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
            

            string password = txtPassword.Text;

            try
            {
                if (password == "lol") //vetem test
                {
                    Form objforma1 = new Form();
                    //E mshef formen e login-it
                    this.Hide();
                    //E Hap formen Kryesore
                    objforma1.Show();
                }
                else
                {
                    MessageBox.Show("Passwordi gabim.",
                        "Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); //basic password wrong error
                }
            }
            catch (Exception)
            {
                //Qetu shto ti diqka Yll :)
            }
        }
    }
}
