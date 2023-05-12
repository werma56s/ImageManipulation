using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageManipulationApp.Interface;

namespace ImageManipulationApp.Classes
{
    internal class ResizedImage : IResizedImage
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ResizedImage(int? width = 200, int? height = 200)
        {
            Width = (int)width;
            Height = (int)height;
        }

        public Bitmap Resized(PictureBox orginalPicure)
        {
            Bitmap coppy = new Bitmap((Bitmap)orginalPicure.Image);
            // To get orginal image from the bitmap
            Image<Bgr, Byte> captureImage = coppy.ToImage<Bgr, byte>();
            // To resize the image 
            Image<Bgr, byte> resizedImage = captureImage.Resize(Width, Height, Emgu.CV.CvEnum.Inter.Linear);
            return resizedImage.ToBitmap();
        }

    }
}
