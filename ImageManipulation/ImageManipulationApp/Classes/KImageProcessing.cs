using ImageManipulationApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Classes
{
    internal class KImageProcessing : ImageProcessing
    {
        public KImageProcessing(IConvertImage convertImage) : base(convertImage)
        {
        }

        public override Bitmap Convert(PictureBox orginalPicure)
        {
            return convertImage.Convert(orginalPicure);
        }
    }
}
