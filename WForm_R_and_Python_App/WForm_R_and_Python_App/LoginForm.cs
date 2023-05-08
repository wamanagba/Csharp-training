using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm_R_and_Python_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            if(id == "" && pass == "")
            {
                this.Hide();
                ScriptForm ff = new ScriptForm();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Password or Email is incorrect");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserID.Text = "";
        }
    }
}
