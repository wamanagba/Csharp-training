using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using IronPython.Hosting;

using IronPython.Modules;
using System.Windows.Forms;

namespace WForm_R_and_Python_App
{

    public partial class Form1 : Form
    {
        // Create a new instance of the Python engine
        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }
    }
}
