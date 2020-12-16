using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantView
{
    public partial class Form1 : Form
    {
        private Bitmap MyImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowMyImage("D:\\WorksStation\\WorkSpace Visual Studio\\C#\\RestaurantSimulationProject\\images\\restaurant.png", 500, 500);
            ShowMyImage("D:\\WorksStation\\WorkSpace Visual Studio\\C#\\RestaurantSimulationProject\\images\\ucacIcam.jpeg", 100, 100);
        }
        public void ShowMyImage(String fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
