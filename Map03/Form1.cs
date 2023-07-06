using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map03
{
    public partial class Form1 : Form
    {
        
        private List<PictureBox> pictureBoxes;

        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox>();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Clear existing PictureBoxes
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Dispose();
            }
            pictureBoxes.Clear();

            // Process the checkboxes
            if (cbJFM.Checked)
            {
                string imagePath1 = System.IO.Path.Combine(Application.StartupPath, "JFM.jpeg");
                Bitmap mapImage1 = new Bitmap(imagePath1);
                AddPictureBox(mapImage1, new Point(10, 110), new Size(200, 300));
            }
            if (cbMAM.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "MAM.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(210, 110), new Size(200, 300));
            }
            if (cbMJJ.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "MJJ.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(400, 110), new Size(200, 300));
            }
            if (cbJAS.Checked)
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "JAS.jpeg");
                Bitmap mapImage = new Bitmap(imagePath);
                AddPictureBox(mapImage, new Point(600, 110), new Size(200, 300));
            }
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

    }
}
