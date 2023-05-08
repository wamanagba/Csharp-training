using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using RDotNet;
using System.IO;
using System.Windows.Forms;

namespace WF_AppPy
{
    public partial class Form1 : Form
    {

        public double meanF;
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            string FirstNumber = txtA.Text;
            string SecondNumber = txtB.Text;
            double first; double second;
            if (double.TryParse(FirstNumber, out first) && double.TryParse(SecondNumber, out second))
            {
                //first = Double.Parse(FirstNumber); // conversion de la chaîne en double
                //second = Double.Parse(SecondNumber); // conversion de la chaîne en double
                
                // Initialisation de la session R
                REngine.SetEnvironmentVariables();
                REngine engine = REngine.GetInstance();

                // Lecture du code R depuis un fichier
                string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "script.R");
                string script = File.ReadAllText(scriptPath);
                // Exécution du code R
                engine.Evaluate(script);

                // Définir la valeur de v
                // Définir les valeurs des paramètres
                //double first = 10.0;
                //double second = 20.0;

                // Convertir les paramètres en vecteur numérique en R
                NumericVector vNumeric = engine.CreateNumericVector(new double[] { first, second });

                // Assigner la valeur de vNumeric dans l'environnement R
                engine.SetSymbol("v", vNumeric);

                // Appeler la fonction Mean de R avec v comme paramètre
                double result = engine.Evaluate("mean(v)").AsNumeric().First();

                // Récupération de la valeur de retour
                double mean = result;
                meanF = mean;

                string myString = meanF.ToString("F2");
                BtnRun.Text = myString;
            }
            else
            {
                MessageBox.Show("Need a numeric Value");
            }

            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            BtnRun.Text = "Mean";
         }
    }
}
