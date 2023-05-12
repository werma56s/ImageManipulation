
using Emgu.CV;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using ImageManipulationApp.Classes;
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
        //Wzorzec - bridge
        KImageProcessing kImageProcessing;
        private void button2_Click(object sender, EventArgs e)
        {
            ConvertToGray convertToGray = new ConvertToGray();
            kImageProcessing = new KImageProcessing(convertToGray);
            this.changedPicture.Image = kImageProcessing.Convert(orginalPicure);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConvertToNegative convertToNegative = new ConvertToNegative();
            kImageProcessing = new KImageProcessing(convertToNegative);
            this.changedPicture.Image = kImageProcessing.Convert(orginalPicure);
        }
        //Wzorzec projektowy - Prototyp
        ActionsImage90 actionsImage = new ActionsImage90();
        private void button4_Click(object sender, EventArgs e)
        {
            this.changedPicture.Image = actionsImage.ResizedImage(orginalPicure);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var actionsImageClone = (ActionsImage90)actionsImage.CopyActionsImage();
            this.changedPicture.Image = actionsImageClone.RotatedPic(orginalPicure);
        }
    }
}