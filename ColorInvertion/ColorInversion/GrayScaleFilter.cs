using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInversion
{
    class GrayScaleFilter : Filters
    {
        short type;
        public GrayScaleFilter(short _type)
        {
            type = _type;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            int Intensity = 0;
            switch (type)
            {
                case 0:
                    Intensity = Average(color);
                    break;
                case 1:
                    Intensity = Lightness(color);
                    break;
                case 2:
                    Intensity = Luminosity(color);
                    break;
                case 3:
                    Intensity = PhotoshopGIMP(color);
                    break;
                case 4:
                    Intensity = ITU_R_BT_709(color);
                    break;
                case 5:
                    Intensity = MaxRGB(color);
                    break;
                case 6:
                    Intensity = MinRGB(color);
                    break;
                case 7:
                    Intensity = Something_else(color);
                    break;
            }
            color = Color.FromArgb(Intensity, Intensity, Intensity);
            return color;
        }

        private int Average(Color color)
        {
            return (int)((color.R + color.G + color.B) / 3);
        }

        private int Lightness(Color color)
        {
            int max = 0, min = 0;
            if (color.R >= color.G && color.R >= color.B)
                max = color.R;
            if (color.G >= color.R && color.G >= color.B)
                max = color.G;
            if (color.B >= color.R && color.B >= color.G)
                max = color.B;
            if (color.R <= color.G && color.R <= color.B)
                min = color.R;
            if (color.G <= color.R && color.G <= color.B)
                min = color.G;
            if (color.B <= color.R && color.B <= color.G)
                min = color.B;
            return (int)((min + max) / 2);
        }

        private int Luminosity(Color color)
        {
            return (int)((0.21 * color.R) + (0.72 * color.G) + (0.07 * color.B));
        }

        private int PhotoshopGIMP(Color color)
        {
            return (int)((0.36 * color.R) + (0.53 * color.G) + (0.11 * color.B));
        }

        private int ITU_R_BT_709(Color color)
        {
            return (int)((0.2126 * color.R) + (0.7152 * color.G) + (0.0722 * color.B));
        }

        private int MaxRGB(Color color)
        {
            int res = 0;
            if (color.R >= color.G && color.R >= color.B)
                res =  color.R;
            if (color.G >= color.R && color.G >= color.B)
                res = color.G;
            if (color.B >= color.R && color.B >= color.G)
                res = color.B;
            return res;
        }

        private int MinRGB(Color color)
        {
            int min = 0;
            if (color.R <= color.G && color.R <= color.B)
                min = color.R;
            if (color.G <= color.R && color.G <= color.B)
                min = color.G;
            if (color.B <= color.R && color.B <= color.G)
                min = color.B;
            return min;
        }

        private int Something_else(Color color)
        {
            return (int)((0.2952 * color.R) + (0.5547 * color.G) + (0.1481 * color.B));
        }
    }
}
