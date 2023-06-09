﻿using ImageManipulationApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApp.Classes
{
    internal class KImageProcessing : ImageProcessing
    {
        public KImageProcessing(IConvertImage convertImage) : base(convertImage){}
        public KImageProcessing(IActionsImage actionsImage) : base(actionsImage){ }
        public KImageProcessing(IResizedImage resizedImage) : base(resizedImage) { }
        public override Bitmap Convert(PictureBox orginalPicure) => convertImage.Convert(orginalPicure);
        public override IActionsImage CopyActionsImage() => actionsImage.CopyActionsImage();
        public override Bitmap Resized(PictureBox orginalPicure) => resizedImage.Resized(orginalPicure);
    }
}
