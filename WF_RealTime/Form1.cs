using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_RealTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer PlotTmer = new System.Windows.Forms.Timer();

        private void RealTimePlot(Object myObject, EventArgs myEventArgs)
        {
            int length = 100;
            double[] x = new double[length];
            double[] y = new double[length];

            for(int i = 0; i<length; i++)
            {
                x[i] = i;
                y[i] = 5 * (Math.Sin(i));

                chart1.Series[0].Points.Add(x[i], y[i]);

            }
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = length;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlotTmer.Interval = 400;
            PlotTmer.Tick += new EventHandler(RealTimePlot);
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if(PlotTmer.Enabled == true)
            {
                PlotTmer.Enabled = false;
            }
            else
            {
                PlotTmer.Enabled = true;
            }
        }
    }
}
