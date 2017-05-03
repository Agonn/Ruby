using System;
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


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDoubleClick(object sender, MouseEventArgs e) //Double click to form mbasi e kom hek border(ma bukur)
        {
            this.Close(); 
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            try
            {
                if (password == "lol") //vetem test.
                {
                    Form objforma1 = new Form();
                    //E mshef formen e login-it
                    this.Hide();
                    //E Hap formen Kryesore
                    objforma1.Show();
                }
                else
                {
                    //basic password wrong error
                    //  MessageBox.Show("Passwordi gabim.",  "Password", MessageBoxButtons.OK,   MessageBoxIcon.Warning); +

                    lblPasswordError.Text = "Passwordi gabim*"; //Ose kjo a annoying popups? I hate popups
                }
            }
            catch (Exception)
            {
                //Qetu shto ti diqka Yll :)
            }
        }
    }
}
