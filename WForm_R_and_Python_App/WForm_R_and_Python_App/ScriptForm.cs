using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using Python.Runtime.Codecs;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

using RDotNet;
using System.IO;
using System.Windows.Forms;

namespace WForm_R_and_Python_App
{
        
    public partial class ScriptForm : Form
    {

        public double meanF;
        public double SumF;
        public double SousF;
        public string MeanString;
        public string SumString;
        public string SousString;
        public string FirstNumber;
        public string SecondNumber;
        public short first;
        public short second;

        public ScriptForm()
        {
            InitializeComponent();



        }

        private void ScriptForm_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnCalcul_Click(object sender, EventArgs e)
        {
            FirstNumber = txtFirstNumber.Text;
            SecondNumber = txtSecondNumber.Text;

            if (short.TryParse(FirstNumber, out first) && short.TryParse(SecondNumber, out second))
            {
                if (rdbR.Checked)
                {
                    // Initialisation de la session R
                    REngine.SetEnvironmentVariables();
                    REngine engine = REngine.GetInstance();

                    // Lecture du code R depuis un fichier
                    string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "script.R");
                    string script = File.ReadAllText(scriptPath);
                    // Exécution du code R
                    engine.Evaluate(script);

                    // Convertir les paramètres en vecteur numérique en R
                    NumericVector vNumeric = engine.CreateNumericVector(new double[] { first, second });

                    // Assigner la valeur de vNumeric dans l'environnement R
                    engine.SetSymbol("v", vNumeric);

                    // Appeler la fonction Mean de R avec v comme paramètre
                    double Mean = engine.Evaluate("mean(v)").AsNumeric().First();
                    double Summ = engine.Evaluate("sum(v)").AsNumeric().First();
                    double Sous = engine.Evaluate("Sous(v)").AsNumeric().First();

                    // Récupération de la valeur de retour
                    double mean = Mean; meanF = mean;
                    double summ = Summ; SumF = summ;
                    double sous = Sous; SousF = sous;


                    string myStringMean = meanF.ToString("F2");
                    lblMean.Text = myStringMean;

                    string myStringSum = SumF.ToString("F2");
                    lblSum.Text = myStringSum;

                    string myStringSous = SousF.ToString("F2");
                    lblSoustraction.Text = myStringSous;

                }



                if (rdbPython.Checked)
                {
                    
                    lblMean.Text = "Python code not Ready";
                    lblSum.Text = "Python code not Ready";
                    lblSoustraction.Text = "Python code not Ready";
                }
            }
            else
            {
                
                lblMean.Text = "...";
                lblSum.Text = "...";
                lblSoustraction.Text = "...";
                MessageBox.Show("Need a numeric number");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
