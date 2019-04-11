using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ColorInversion
{
  class MatrixFilter
  {
    protected float[,] kernel = null;
    protected MatrixFilter() { }

    public MatrixFilter(float[,] _kernel)
    {
      if (_kernel.GetLength(0) != _kernel.GetLength(1))
        throw new Exception("Hig != Wh");
      kernel = _kernel;
    }

    public Color CalculateNewColor(Bitmap sourceImg, int x, int y)
    {
      int rad = kernel.GetLength(0) / 2;

      float resR = 0;
      float resG = 0;
      float resB = 0;

      for (int l = -rad; l <= rad; l++)
        for (int k = -rad; k <= rad; k++)
        {
          int idX = Clamp(x + k, 0, sourceImg.Width - 1);
          int idY = Clamp(y + l, 0, sourceImg.Height - 1);
          Color nCol = sourceImg.GetPixel(idX, idY);
          resR += nCol.R * kernel[k + rad, l + rad];
          resG += nCol.G * kernel[k + rad, l + rad];
          resB += nCol.B * kernel[k + rad, l + rad];
        }

      return Color.FromArgb(
        Clamp((int)resR, 0, 255),
        Clamp((int)resG, 0, 255),
        Clamp((int)resB, 0, 255));
    }

    public int CalculateNewTr(Bitmap sourceImg, int x, int y)
    {
      int rad = kernel.GetLength(0) / 2;

      /* int min = 255, max = 0;

       for (int l = -rad; l <= rad; l++)
         for (int k = -rad; k <= rad; k++)
         {
           int idX = Clamp(x + k, 0, sourceImg.Width - 1);
           int idY = Clamp(y + l, 0, sourceImg.Height - 1);
           Color nCol = sourceImg.GetPixel(idX, idY);
           if((nCol.R + nCol.B + nCol.G)/3 < min)
             min = (nCol.R + nCol.B + nCol.G)/ 3;
           if ((nCol.R + nCol.B + nCol.G) / 3 > max)
             max = (nCol.R + nCol.B + nCol.G) / 3;
         }

       return (max + min) / 2 -15;*/


      int sum = 0;
      int iter = 0;
      for (int l = -rad; l <= rad; l++)
        for (int k = -rad; k <= rad; k++)
        {
          int idX = Clamp(x + k, 0, sourceImg.Width - 1);
          int idY = Clamp(y + l, 0, sourceImg.Height - 1);
          Color nCol = sourceImg.GetPixel(idX, idY);
          sum += nCol.R;
          sum += nCol.G;
          sum += nCol.B;
          iter++;
        }

      return sum / (3 * iter) - 10;
    }

    private int Clamp(int val, int min, int max)
    {
      if (val < min)
        return min;
      else if (val > max)
        return max;
      else
        return val;
    }
  }
}
