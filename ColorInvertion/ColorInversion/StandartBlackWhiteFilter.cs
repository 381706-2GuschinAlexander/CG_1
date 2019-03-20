using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInversion
{
    class StandartBlackWhiteFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            int Intemsity = (int)((color.R + color.G + color.B) / 3);
            if (Intemsity > 128)
                Intemsity = 255;
            else
                Intemsity = 0;
            color = Color.FromArgb(Intemsity, Intemsity, Intemsity);
            return color;
        }
    }
}
