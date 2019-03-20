using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInversion
{
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float [,] _kernel)
        {
            kernel = _kernel;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0, resultG = 0, resultB = 0;
            for (int a = -radiusY; a <= radiusY; a++)
                for(int b = -radiusX; b <= radiusX; b++)
                {
                    int idX = Clamp(i + b, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + a, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[b + radiusX, a + radiusY];
                    resultG += neighborColor.G * kernel[b + radiusX, a + radiusY];
                    resultB += neighborColor.B * kernel[b + radiusX, a + radiusY];
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));   
        }
    }
}
