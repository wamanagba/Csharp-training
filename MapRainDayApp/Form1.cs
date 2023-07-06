using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDotNet;
using System.IO;
using System.Windows.Forms;

namespace MapRainDayApp
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pictureBoxes;
        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox>();
        }

        private void AddPictureBox(Bitmap image, Point location, Size size)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = location,
                Size = size
            };
            Controls.Add(pictureBox);
            pictureBoxes.Add(pictureBox);
        }

        private void BtnProcessing_Click(object sender, EventArgs e)
        {
            // R session initialization 
            REngine.SetEnvironmentVariables("C:/Program Files/R/R-3.6.0/bin/i386", "C:/Program Files/R/R-3.6.0");
            REngine engine = REngine.GetInstance();

            // Read R code from a file
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts.R");
            string script = File.ReadAllText(scriptPath);
            // Running the R code
            engine.Evaluate(script);

            // Call the 'mean' function from R code named Calcul
            string month = tbProcessing.Text;
            engine.Evaluate($"Processing(\"{month}\")");
            MessageBox.Show("End of Processing");
        }

       
        private void BtnMap_Click(object sender, EventArgs e)
        {
            REngine.SetEnvironmentVariables("C:/Program Files/R/R-3.6.0/bin/i386", "C:/Program Files/R/R-3.6.0");
            REngine engine = REngine.GetInstance();
            // Read R code from a file
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts.R");
            string script = File.ReadAllText(scriptPath);
            // Running the R code
            engine.Evaluate(script);

            // Call the 'mean' function from R code named Calcul
            string month = tbGenerate.Text;
            engine.Evaluate($"Monthly_RainDay(\"{month}\")");
            //engine.Evaluate($"Number20(\"{month}\")");
            MessageBox.Show("END");
        }

        private void BtnDisplayMap_Click(object sender, EventArgs e)
        {
            // Clear existing PictureBoxes
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Dispose();
            }
            pictureBoxes.Clear();



            // Process the checkboxes
            if (cbJan.Checked)
            {
                string imagePath1 = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/Jan/NumberRainDay.jpeg");
                Bitmap mapImage1 = new Bitmap(imagePath1);
                AddPictureBox(mapImage1, new Point(10, 85), new Size(200, 300));
            }
            if (cbFeb.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/Feb/NumberRainDay.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(210, 85), new Size(200, 300));
            }
            if (cbMar.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/Mar/NumberRainDay.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(400, 85), new Size(200, 300));
            }
            if (cbApr.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/Apr/NumberRainDay.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(600, 85), new Size(200, 300));
            }

            if (cbMay.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/May/NumberRainDay.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(10, 380), new Size(200, 300));
            }

            if (cbJun.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Data/Monthly_RainDay/Jun/NumberRainDay.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(210, 380), new Size(200, 300));
            }
        }
    }
}
