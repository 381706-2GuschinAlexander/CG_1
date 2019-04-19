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
  
  class GGC
  {
  
    protected Bitmap bmp;
    protected string filename;

    public GGC(Bitmap _bmp, string _name)
    {
      bmp = _bmp;
      filename = _name;
    }

    public bool ComparePic(Bitmap fir, Bitmap sec)
    {
      if (fir.Height != sec.Height)
        return false;
      if (fir.Width != sec.Width)
        return false;

      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color colorF = fir.GetPixel(i, j);
          Color colorS = sec.GetPixel(i, j);
          if (colorF != colorS)
            return false;
        }

      return true;
    }

    public Bitmap GetPic()
    {
      return bmp;
    }

    public void Inversion()
    {
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color color = bmp.GetPixel(i, j);
          color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
          bmp.SetPixel(i, j, color);
        }
    }

    public void Average()
    {
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color color = bmp.GetPixel(i, j);
          int aver = (color.R + color.G + color.B) / 3;
          color = Color.FromArgb(aver, aver, aver);
          bmp.SetPixel(i, j, color);
        }
    }

    public void Lightness()
    {
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color color = bmp.GetPixel(i, j);
          int res = (Math.Min(color.R, Math.Min(color.G ,color.B)) +
            Math.Max(color.R, Math.Max(color.G, color.B))) / 2;
          color = Color.FromArgb(res, res, res);
          bmp.SetPixel(i, j, color);
        }
    }

    public void Blur()
    {
      float[,] kernel;
      kernel = new float[3, 3];
      for (int i = 0; i < kernel.GetLength(0); i++)
        for (int j = 0; j < kernel.GetLength(0); j++)
          kernel[i, j] = 1.0f / 9.0f;

      MatrixFilter BlurStd = new MatrixFilter(kernel);

      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
          bmp.SetPixel(i, j, BlurStd.CalculateNewColor(bmp, i, j));
    }


    public void AdaptiveBin()
    {
      float[,] kernel;
      kernel = new float[5, 5];
      
      MatrixFilter Adaptive = new MatrixFilter(kernel);

      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color tmp = bmp.GetPixel(i,j);
          if ((tmp.R + tmp.G + tmp.B) / 3 > Adaptive.CalculateNewTr(bmp, i, j))
            bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
          else
            bmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
        }
    }

    public void Threshold()
    {
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color tmp = bmp.GetPixel(i, j);
          if ((tmp.R + tmp.G + tmp.B) / 3 > 128)
            bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255));
          else
            bmp.SetPixel(i, j, Color.FromArgb(0, 0, 0));
        }
    }
  }
}
