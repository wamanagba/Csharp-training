using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronPython.Hosting;

namespace WFDssat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Infile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txb_InFile.Text = diag.SelectedPath;
            }
            else
            {
                txb_InFile.Text = "";
                MessageBox.Show("Please Select the path of your csv file");
            }
  
        }

        private void Btn_OutputWth_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag2 = new FolderBrowserDialog();
            if (diag2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txb_OuputWth.Text = diag2.SelectedPath;
            }
            else
            {
                txb_OuputWth.Text = "";
                MessageBox.Show("Please Select the folder path for your output with wth files");
            }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            //Instance of python engine
            var enginePy = Python.CreateEngine();
            //Reading code from file
            var source = enginePy.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DssatScripts/Main.py"));
            var scope = enginePy.CreateScope();
            //Executing script in scope
            source.Execute(scope);
            var classCalculator = scope.GetVariable("main");
            //Initializing class
            var calculatorInstance = enginePy.Operations.CreateInstance(classCalculator);
            //get the result
           // var Rsum = calculatorInstance.sum(first, second);
            //var Rmean = calculatorInstance.Mean(first, second);
            //var Rsous = calculatorInstance.Sous(first, second);

            // Show results
            //lblMean.Text = Rmean.ToString();
            //lblSum.Text = Rsum.ToString();
            //lblSoustraction.Text = Rsous.ToString();
        }
    }
}
