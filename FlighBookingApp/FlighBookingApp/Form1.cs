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
    public partial class Form1 : Form
    {
        public static Boolean Passport, IDCardNo;
        public static string To, From, StartTripDate, EndTripDate, FirstName, LastName, DocumentNo, IssueDate, ExpiryDate,WeightBaggage;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            To = txtTo.Text;
            From = txtFrom.Text;

            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");

            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            DocumentNo = txtDocumentNo.Text;

            IssueDate = dateTimePicker1.Value.ToString("dd MMM yyyy");
            ExpiryDate = dateTimePicker2.Value.ToString("dd MMM yyyy");

            WeightBaggage = numericUpDown1.Value.ToString();


            this.Hide();
            Form2 ff2 = new Form2();
            ff2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;

            numericUpDown1.Increment = 10;
            numericUpDown1.ReadOnly = true;

        }

        private void RdbIdCard_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbIdCard.Checked)
            {
                lblDocNo.Text = "ID Card No:";
                lblIssueDate.Text = "ID Card Issue Date:";
                lblExpiryDate.Text = "ID Card Expiry Date:";

                IDCardNo = true;
            }
            else
            {
                IDCardNo = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void RdbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbPassport.Checked)
            {
                lblDocNo.Text = "Passport No:";
                lblIssueDate.Text = "Passport Issue Date:";
                lblExpiryDate.Text = "Passport Expiry Date:";

                Passport = true;
            }
            else
            {
                Passport = false;
            }
        }
    }
}
