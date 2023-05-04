using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Net;

namespace MailOutlook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on cree l'app outlook
            Outlook.Application app= new Outlook.Application();
            // On cree le mail item
            Outlook.MailItem msg = (Outlook.MailItem)app.CreateItem(Outlook.OlItemType.olMailItem);
            // Maintenant le body du mail
            msg.HTMLBody = "Bonjour Mamadou, voici resolu ton problem";
            // Le sujet du mail
            msg.Subject = "Problem resolu";
            // On definit le destinateur
            Outlook.Recipients recips = (Outlook.Recipients)msg.Recipients;
            Outlook.Recipient recip = (Outlook.Recipient)recips.Add("yacoubu02@gmail.com");
            recip.Resolve();
            //Envoi du mail mainteant
            msg.Send();
            // Nettoyer tous maintenant
            recip = null;
            recips= null;
            msg= null;
            app = null;

            
            // Un message de configuration d'envoi du mail
            MessageBox.Show("Un mai a ete envoye a votre destinateur, Merci bien");
        }
    }
}
