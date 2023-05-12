using ImageManipulationApp.Interface;

namespace ImageManipulationApp.Classes
{
    internal class ConvertToNegative : IConvertImage
    {
        public Bitmap Convert(PictureBox orginalPicure)
        {
            Bitmap b = new Bitmap((Bitmap)orginalPicure.Image);
            for (int i = 0; i < b.Width; i++)    // Loop for Width
                for (int j = 0; j < b.Height; j++)    // Loo for Height
                {

                    Color c1 = b.GetPixel(i, j);    // Get Pixel from colour
                    int a = c1.A;    // Extracting ARGB from pixel colour
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    // For negative values

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;

                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));   // Setting new colour for negative processed image
                }
            return b;
        }
    }
}
