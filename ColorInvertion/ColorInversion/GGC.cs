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

    /*public void SetPic(Bitmap _bmp, string _name)
    {
      bmp = _bmp;
      filename = _name;
    }*/

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


  }
}
