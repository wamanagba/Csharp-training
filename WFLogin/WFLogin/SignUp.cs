using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLogin
{
    public partial class SignUp : Form
    {

        public static string fName;
        public static string lname;
        public static string emailAddress;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;
        Confirmation c = new Confirmation();
        public SignUp()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lname = txtLastName.Text;
            emailAddress = txtEmailAddress.Text;

            this.Hide();
            c.Show();
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSMS.Checked)
            {
                sms = true;
                lblSMSMessage.Text = "Services charges may apply for SMS.";

            }
            else
            {
                sms = false;
                lblSMSMessage.Text = ".....";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                transactions = true;
                lblTransactionMessage.Text = "Services charges may apply transaction.";

            }
            else
            {
                transactions = false;
                lblTransactionMessage.Text = ".....";
            }
        }
    }
    
    
}
