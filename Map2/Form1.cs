


using System;
using System.Drawing;
using System.Windows.Forms;
using RDotNet;
using System.IO;

namespace Map2
{
    public partial class Form1 : Form
    {
        private REngine engine;
        private PictureBox pictureBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }



      

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            //Specifies the path to the R binary
            REngine.SetEnvironmentVariables("C:/Program Files/R/R-3.6.0/bin/i386", "C:/Program Files/R/R-3.6.0");

            // R session initialization 
            REngine engine = REngine.GetInstance();

            // Read R code from a file
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts.R");
            string script = File.ReadAllText(scriptPath);
            // Running the R code
            engine.Evaluate(script);

            MessageBox.Show("Download Succefully");

            // Récupérer la carte générée en tant qu'image et créer le contrôle PictureBox
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Percentage_Aug_2022.jpeg");
            Bitmap mapImage = new Bitmap(imagePath);

            // Créer le contrôle PictureBox
            pictureBox = new PictureBox
            {
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 10),
                Size = new Size(200, 300)
            };

            pictureBox2 = new PictureBox
            {
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(200, 10),
                Size = new Size(200, 300)
            };

            pictureBox3 = new PictureBox
            {
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(400, 10),
                Size = new Size(200, 300)
            };

            pictureBox4 = new PictureBox
            {
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 320),
                Size = new Size(200, 300)
            };

            Controls.Add(pictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermer l'environnement R.NET
            engine.Dispose();
        }
    }
}
