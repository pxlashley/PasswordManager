using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = txtuser.Text;
            password = txtpass.Text;

            if (username.Equals("Admin") && password.Equals("Admin"))
            {
                MessageBox.Show("Login Successful");

            }
            Login Login = new Login(); // Create an instance of Form3
            Form1.Show();  // Show Form3

            this.Hide();  // Hide the current form
        }
    }
}
