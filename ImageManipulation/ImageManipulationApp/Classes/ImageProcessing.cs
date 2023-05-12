using ImageManipulationApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Classes
{
    abstract class ImageProcessing 
    {
        protected  IConvertImage convertImage;

        public ImageProcessing(IConvertImage convertImage)
        {
            this.convertImage = convertImage;
        }
        public abstract Bitmap Convert(PictureBox orginalPicure);
    }
}
