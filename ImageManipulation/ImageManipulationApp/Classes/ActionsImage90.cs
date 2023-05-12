﻿using Emgu.CV.Structure;
using Emgu.CV;
using ImageManipulationApp.Interface;

namespace ImageManipulationApp.Classes
{
    internal class ActionsImage90 : IActionsImage
    {
        public  int? Width { get; set; }
        public  int? Height { get; set; }
        public ActionsImage90(int? width = 200, int? height = 200)
        {
            Width = width;
            Height = height;
        }
        public  Bitmap ResizedImage(PictureBox orginalPicure)
        {
            Bitmap coppy = new Bitmap((Bitmap)orginalPicure.Image);
            // To get orginal image from the bitmap
            Image<Bgr, Byte> captureImage = coppy.ToImage<Bgr, byte>();
            // To resize the image 
            Image<Bgr, byte> resizedImage = captureImage.Resize(200, 200, Emgu.CV.CvEnum.Inter.Linear);
            return resizedImage.ToBitmap();
        }

        public  Bitmap RotatedPic(PictureBox orginalPicure)
        {
            Bitmap rotatedPic = new Bitmap((Bitmap)orginalPicure.Image);
            rotatedPic.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return rotatedPic;
        }

        public  IActionsImage CopyActionsImage()
        {
            return (IActionsImage)MemberwiseClone();
        }
    
    }
}
