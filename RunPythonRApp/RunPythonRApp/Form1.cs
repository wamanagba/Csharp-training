using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunPythonRApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserID.Text;
            string pass = txtPassword.Text;

            if (id == "" && pass == "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserID.Text = "";
        }
    }
}
