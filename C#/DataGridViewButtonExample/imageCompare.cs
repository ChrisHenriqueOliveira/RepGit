using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewButtonExample
{
    public class imageCompare
    {

        static Bitmap reduceImage(Bitmap image, int width, int height)
        {
            Bitmap reducedImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(reducedImage);

            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(image, 0, 0, width, height);
            graphics.Dispose();

            return reducedImage;
        }

        static List<bool> generateHash(Bitmap image)
        {
            List<bool> hash = new List<bool>();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    hash.Add(image.GetPixel(x, y).GetBrightness() < 0.5f);
                }
            }

            return hash;
        }

        public static Bitmap grayScale(Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
            {
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }

            return Bmp;
        }

        static int equalPixels(List<bool> pixel1, List<bool> pixel2)
        {
            int equalPixelsAmount = 0;
            int pixelsToCompare = (pixel1.Count + pixel2.Count) / 2;

            for(int i = 0; i < pixelsToCompare; i++)
            {
                if(pixel1[i] == pixel2[i])
                {
                    equalPixelsAmount++;
                }
            }

            return equalPixelsAmount;
        }

        public float compareImages(string pathImage1, string pathImage2)
        {
            Bitmap img1Bitmap = new Bitmap(pathImage1);
            Bitmap img2Bitmap = new Bitmap(pathImage2);

            Bitmap img1BitmapReduced = reduceImage(img1Bitmap, 1000, 1000);
            Bitmap img2BitmapReduced = reduceImage(img2Bitmap, 1000, 1000);

            Bitmap img1BitmapBxW = grayScale(img1BitmapReduced);
            Bitmap img2BitmapBxW = grayScale(img2BitmapReduced);

            List<bool> image1Hash = generateHash(img1BitmapBxW);
            List<bool> image2Hash = generateHash(img2BitmapBxW);

            int pixelsEqualQtt = equalPixels(image1Hash, image2Hash);

            float area = img1BitmapReduced.Width * img2BitmapReduced.Height;
            float _decimal = pixelsEqualQtt / area;
            float hitPercent = _decimal * 100;

            return hitPercent;
        }


    }
}
