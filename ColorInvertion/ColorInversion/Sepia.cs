using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInversion
{
    class Sepia : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            int Intensity = (int)((0.36 * color.R) + (0.53 * color.G) + (0.11 * color.B));
            color = Color.FromArgb(Clamp(Intensity + 2 * 20, 0, 255), Clamp(Intensity - 10, 0, 255), Clamp(Intensity - 20, 0, 255));
            return color; ;
        }
    }
}
