
using Emgu.CV;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using System.Drawing;
using System.IO;
using static Emgu.CV.DenseRLOFOpticalFlow;

namespace ImageManipulationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();
                    PictureBox1.Image = new Bitmap(dlg.FileName);
                    orginalPicure.Image = PictureBox1.Image;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.orginalPicure.Image);

            ImageProccessingMethod.ConvertToGray(coppy);
            this.changedPicture.Image = coppy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.orginalPicure.Image);

            ImageProccessingMethod.ConvertToNegative(coppy);
            this.changedPicture.Image = coppy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.orginalPicure.Image);
            // To get orginal image from the bitmap
            Image<Bgr, Byte> captureImage = coppy.ToImage<Bgr, byte>();
            // To resize the image 
            Image<Bgr, byte> resizedImage = captureImage.Resize(200, 200, Emgu.CV.CvEnum.Inter.Linear);
            this.changedPicture.Image = resizedImage.ToBitmap();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap rotatedPic = new Bitmap((Bitmap)this.orginalPicure.Image);
            rotatedPic.RotateFlip(RotateFlipType.Rotate270FlipX);
            this.changedPicture.Image = rotatedPic;
        }
    }
}