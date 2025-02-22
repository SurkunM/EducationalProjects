using System.Drawing;
using System.Drawing.Imaging;

namespace BlackAndWhiteL13_1;

internal class BlackAndWhite
{
    static void Main(string[] args)
    {
        using Bitmap image = new Bitmap("..\\..\\..\\image.jpg");

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);

                int greyColor = (int)Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B, MidpointRounding.AwayFromZero);
                Color newPixel = Color.FromArgb(greyColor, greyColor, greyColor);

                image.SetPixel(x, y, newPixel);
            }
        }

        image.Save("..\\..\\..\\outImage.jpg", ImageFormat.Jpeg);
    }
}