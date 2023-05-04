using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string input;

            if(radioButton1.Checked == true)
            {
                input = radioButton1.Text;
                MessageBox.Show(input + " has been selected");
            }

            if (radioButton2.Checked == true)
            {
                input = radioButton2.Text;
                MessageBox.Show(input + " has been selected");

            }

            if (radioButton3.Checked == true)
            {
                input = radioButton3.Text;
                MessageBox.Show(input + " has been selected");

            }
        }
    }
}
