using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using System.IO;
using RDotNet;
using System.Windows.Forms;

namespace RunPythonRApp
{
    public partial class ScriptForm : Form
    {

        public ScriptForm()
        {
            InitializeComponent();
        }

        private void BtnCalcul_Click(object sender, EventArgs e)
        {
            string FirstNumber = txtFirstNumber.Text;
            string SecondNumber = txtSecondNumber.Text;
            double first;
            double second;
            if (double.TryParse(FirstNumber, out first) && double.TryParse(SecondNumber, out second))
            {
                if (rdbR.Checked)
                {
                    // Initialization of the R session
                    REngine.SetEnvironmentVariables();
                    REngine engine = REngine.GetInstance();

                    //Reading code from file
                    string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "script.R");
                    string script = File.ReadAllText(scriptPath);
                    // Running the R code
                    engine.Evaluate(script);

                    // Convert parameters to numerical vector in R
                    NumericVector vNumeric = engine.CreateNumericVector(new double[] { first, second });

                    // Assign the value of vNumeric in the R environment
                    engine.SetSymbol("v", vNumeric);

                    // Call the Mean, Sum and Sub functions of R with v as parameter
                    double Mean = engine.Evaluate("mean(v)").AsNumeric().First();
                    double Summ = engine.Evaluate("sum(v)").AsNumeric().First();
                    double Sous = engine.Evaluate("Sous(v)").AsNumeric().First();

                    // Show results
                    lblMean.Text = Mean.ToString("F2");
                    lblSum.Text = Summ.ToString("F2");
                    lblSoustraction.Text = Sous.ToString("F2");

                }

                if (rdbPython.Checked)
                {
                    //Instance of python engine
                    var enginePy = Python.CreateEngine();
                    //Reading code from file
                    var source = enginePy.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simple.py"));
                    var scope = enginePy.CreateScope();
                    //Executing script in scope
                    source.Execute(scope);
                    var classCalculator = scope.GetVariable("calculator");
                    //Initializing class
                    var calculatorInstance = enginePy.Operations.CreateInstance(classCalculator);
                    //get the result
                    var Rsum = calculatorInstance.sum(first, second);
                    var Rmean = calculatorInstance.Mean(first, second);
                    var Rsous = calculatorInstance.Sous(first, second);

                    // Show results
                    lblMean.Text = Rmean.ToString();
                    lblSum.Text = Rsum.ToString();
                    lblSoustraction.Text = Rsous.ToString();
                }

            }
            else
            {

                lblMean.Text = "...";
                lblSum.Text = "...";
                lblSoustraction.Text = "...";
                MessageBox.Show("Enter real numbers");

            }
        }

        private void Btncsp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMean.Text = "...";
            lblSoustraction.Text = "...";
            lblSum.Text = "...";
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";


        }

        private void ScriptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
