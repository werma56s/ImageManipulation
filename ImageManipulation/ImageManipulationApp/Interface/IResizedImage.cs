using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Interface
{
    internal interface IResizedImage
    {
        int Width { get; set; }
        int Height { get; set; }
        Bitmap Resized(PictureBox orginalPicure);
    }
}
