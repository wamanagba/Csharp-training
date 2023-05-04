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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFName.Text = SignUp.fName;
            lblLName.Text = SignUp.lname;
            lblEmailAddress.Text = SignUp.emailAddress;

            if (SignUp.sms)
            {
                lblSMS.Text = "✓";
            }
            if (SignUp.reports)
            {
                lblreports.Text = "✓";
            }
            if (SignUp.transactions)
            {
                lblTransactions.Text = "✓";
            }
        }
    }
}
