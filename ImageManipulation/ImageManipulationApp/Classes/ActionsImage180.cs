using Emgu.CV.Structure;
using Emgu.CV;
using ImageManipulationApp.Interface;

namespace ImageManipulationApp.Classes
{
    internal class ActionsImage180 : IActionsImage
    {
        public Bitmap RotatedPic(PictureBox orginalPicure)
        {
            Bitmap rotatedPic = new Bitmap((Bitmap)orginalPicure.Image);
            rotatedPic.RotateFlip(RotateFlipType.Rotate180FlipX);
            return rotatedPic;
        }

        public IActionsImage CopyActionsImage()
        {
            return (IActionsImage)MemberwiseClone();
        }
    }
}
