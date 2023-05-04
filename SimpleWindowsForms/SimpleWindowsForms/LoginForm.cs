using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindowsForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            if (id == "Yacoub" && pass == "1574")
            {
                this.Hide();

                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or UserID is incorrect ...");
            }
        }

        private void ResetMyForm()
        {
            txtPassword.Text = "";
            txtUserID.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if(e.KeyChar == (char)Keys.Enter)
            {
                ResetMyForm();
            }
        }
    }
}
