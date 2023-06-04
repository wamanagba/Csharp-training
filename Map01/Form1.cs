


using System;
using System.Drawing;
using System.Windows.Forms;
using RDotNet;

namespace Map01
{
    public partial class Form1 : Form
    {
        private REngine engine;
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
        }


        private void btnGenerateMap_Click_1(object sender, EventArgs e)
        {
            REngine.SetEnvironmentVariables("C:/Program Files/R/R-3.6.0/bin/i386", "C:/Program Files/R/R-3.6.0");
            engine = REngine.GetInstance();
            engine.Initialize();
            // Exécuter le script R
            string script = @"
                library(ggplot2)
                library(maps)
                map <- map_data('world')
                p <- ggplot() +
                    geom_polygon(data = map, aes(x = long, y = lat, group = group), fill = 'lightblue', color = 'black') +
                    coord_equal() +
                    labs(title = 'Carte du monde', subtitle = 'Exemple de carte géographique') +
                    theme_minimal()
                ggsave('carte.png', plot = p)
            ";
            engine.Evaluate(script);

            // Récupérer la carte générée en tant qu'image et créer le contrôle PictureBox
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "carte.png");
            Bitmap mapImage = new Bitmap(imagePath);

            // Créer le contrôle PictureBox
            pictureBox = new PictureBox
            {
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 10),
                Size = new Size(800, 600)
            };

            Controls.Add(pictureBox);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermer l'environnement R.NET
            engine.Dispose();
        }
    }
}
