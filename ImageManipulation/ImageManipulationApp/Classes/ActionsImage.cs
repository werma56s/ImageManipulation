using ImageManipulationApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Classes
{
    abstract class ActionsImage 
    {
        public abstract int? Width { get; set; }
        public abstract int? Height { get; set; }
        public abstract Bitmap ResizedImage(PictureBox orginalPicure);
        public abstract Bitmap RotatedPic(PictureBox orginalPicure);
        public abstract ActionsImage CopyActionsImage();
    }
}
