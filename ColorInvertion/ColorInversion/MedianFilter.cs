using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInversion
{
    class MedianFilter : Filters
    {
        int radius;

        int[] masR;
        int[] masG;
        int[] masB;

        int medR, medG, medB;

        public MedianFilter()
        {
            radius = 1;
            masR = new int[(2 * radius + 1) * (2 * radius + 1)];
            masG = new int[(2 * radius + 1) * (2 * radius + 1)];
            masB = new int[(2 * radius + 1) * (2 * radius + 1)];
            medR = medG = medB = 0;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            if (i < radius || i > sourceImage.Width - radius)
                return sourceImage.GetPixel(i, j);
            if(j < radius || j > sourceImage.Height - radius)
                return sourceImage.GetPixel(i, j);
            GetMedian(sourceImage, i, j);
            return Color.FromArgb(medR, medG, medB);
        }

        private void GetMedian(Bitmap sourceImage, int i, int j)
        {
            int count = 0;
            for (int a = -radius; a <= radius; a++)
                for (int b = -radius; b <= radius; b++)
                {
                    Color color = sourceImage.GetPixel(i - a, j - b);
                    masR[count] = color.R;
                    masG[count] = color.G;
                    masB[count] = color.B;
                    count++;
                }
            Array.Sort(masR);
            Array.Sort(masG);
            Array.Sort(masB);
            int median = (2 * radius + 1) * (2 * radius + 1) / 2;
            medR = masR[median];
            medG = masG[median];
            medB = masB[median];
        }
    }
}
