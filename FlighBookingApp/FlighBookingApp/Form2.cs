using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlighBookingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form1.Passport == true)
            {
                lblChangeDocument.Text = "Passport No";
                lblChangeExpiryDate.Text = " Passport Expiry Date ";
            }

            if (Form1.IDCardNo == true)
            {
                lblChangeDocument.Text = "ID Card No";
                lblChangeExpiryDate.Text = " ID Card Expiry Date ";
            }


            lblFullName.Text = Form1.FirstName + " " + Form1.LastName;
            lblDeparture.Text = Form1.From;
            lblDestination.Text = Form1.To;
            lblTripeDate.Text = Form1.StartTripDate + " to " + Form1.EndTripDate;
            lblDocumentNo.Text = Form1.DocumentNo;
            lblDocExpiry.Text = Form1.ExpiryDate;
            lblBaggages.Text = Form1.WeightBaggage;



        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
