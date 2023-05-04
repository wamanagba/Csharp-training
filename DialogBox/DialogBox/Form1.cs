using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: to Purchasse, press 'Yes' \n 2: For trial Version, press '2' \n 3: Cancel Order", "Purchase Soltware", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

            if(dr == DialogResult.Yes)
            {
                lblYesNo.Text = "Your have purchased soltware, Congratulation.";
                lblCancel.Text = "....";

            }

            if (dr == DialogResult.No)
            {
                lblYesNo.Text = "30 day Trial version start, Congratulation.";
                lblCancel.Text = "....";
            }

            if (dr == DialogResult.Cancel)
            {
                lblCancel.Text = "You have cancelled the oder.";
                lblYesNo.Text = "....";

            }
        }
    }
}
