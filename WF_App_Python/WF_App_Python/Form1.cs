using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IronPython.Hosting;
namespace WF_App_Python
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMean_Click(object sender, EventArgs e)
        {
            //instance of python engine
            var enginePy = Python.CreateEngine();
            //reading code from file
            var source = enginePy.CreateScriptSourceFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simple.py"));
            var scope = enginePy.CreateScope();
            //executing script in scope
            source.Execute(scope);
            var classCalculator = scope.GetVariable("calculator");
            //initializing class
            var calculatorInstance = enginePy.Operations.CreateInstance(classCalculator);
            var result= calculatorInstance.sum(5, 10);
            BtnMean.Text = result.ToString();
        }
    }
}
