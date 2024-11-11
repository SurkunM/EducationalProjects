using System.Drawing;
using System.Drawing.Imaging;

namespace BlurL13;

internal class Blur
{
    public static int GetSaturatedColor(double color)
    {
        if (color <= 0)
        {
            return 0;
        }

        if (color >= 255)
        {
            return 255;
        }

        return (int)Math.Round(color, MidpointRounding.AwayFromZero);
    }

    public static double[,] GetBlurMatrix(int blurMatrixSize)
    {
        double[,] matrix = new double[blurMatrixSize, blurMatrixSize];
        double ratio = 1.0 / matrix.Length;

        for (int i = 0; i < blurMatrixSize; i++)
        {
            for (int j = 0; j < blurMatrixSize; j++)
            {
                matrix[i, j] = ratio;
            }
        }

        return matrix;
    }

    static void Main(string[] args)
    {
        using Bitmap originalImage = new Bitmap("..\\..\\..\\image.jpg");
        using Bitmap resultImage = new Bitmap(originalImage);

        double[,] matrix = GetBlurMatrix(3);

        int halfMatrixSize = matrix.GetLength(0) / 2;
        int yUpperLimit = originalImage.Height - halfMatrixSize;
        int xUpperLimit = originalImage.Width - halfMatrixSize;

        for (int y = halfMatrixSize; y < yUpperLimit; y++)
        {
            for (int x = halfMatrixSize; x < xUpperLimit; x++)
            {
                double redColor = 0;
                double greenColor = 0;
                double blueColor = 0;

                for (int i = 0, yNeighboringPixel = y - halfMatrixSize; i < matrix.GetLength(0); i++, yNeighboringPixel++)
                {
                    for (int j = 0, xNeighboringPixel = x - halfMatrixSize; j < matrix.GetLength(0); j++, xNeighboringPixel++)
                    {
                        Color pixel = originalImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redColor += pixel.R * matrix[i, j];
                        greenColor += pixel.G * matrix[i, j];
                        blueColor += pixel.B * matrix[i, j];
                    }
                }

                Color resultPixel = Color.FromArgb(GetSaturatedColor(redColor), GetSaturatedColor(greenColor), GetSaturatedColor(blueColor));

                resultImage.SetPixel(x, y, resultPixel);
            }
        }

        resultImage.Save("..\\..\\..\\resultImage.jpg", ImageFormat.Jpeg);
    }
}