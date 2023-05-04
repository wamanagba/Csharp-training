using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTimeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lblDateTime.Text = dtpicker.Value.ToString();
            lblDate.Text = dtpicker.Value.ToString("dddd, MMM dd, yyyy");
            lbl3DateDay.Text = dtpicker.Value.ToLongDateString();
            lbl4Time.Text = dtpicker.Value.ToShortTimeString();
            lblTimeSeconds.Text = dtpicker.Value.ToLongTimeString();

        }
    }
}
