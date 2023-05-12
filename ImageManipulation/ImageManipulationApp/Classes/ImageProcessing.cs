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
        protected IActionsImage actionsImage;

        public ImageProcessing(IConvertImage convertImage)
        {
            this.convertImage = convertImage;
        }
        public ImageProcessing(IActionsImage actionsImage)
        {
            this.actionsImage = actionsImage;
        }
        public abstract Bitmap Convert(PictureBox orginalPicure);

        public abstract IActionsImage CopyActionsImage();
    }
}
