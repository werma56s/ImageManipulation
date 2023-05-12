using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Interface
{
     interface IActionsImage
    {
          int? Width { get; set; }
          int? Height { get; set; }
          Bitmap ResizedImage(PictureBox orginalPicure);
          Bitmap RotatedPic(PictureBox orginalPicure);
          IActionsImage CopyActionsImage();
    }
}
