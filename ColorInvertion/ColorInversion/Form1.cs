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
  public partial class Form1 : Form
  {
    GGC pic;
    public Form1()
    {
      InitializeComponent();
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
       
        pic = new GGC(new Bitmap(openFileDialog1.FileName), openFileDialog1.FileName);
        pictureBox1.Image = pic.GetPic();
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        pic.GetPic().Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
      }
    }

    private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Inversion();
      pictureBox1.Image = pic.GetPic();
    }

    private void averToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Average();
      pictureBox1.Image = pic.GetPic();
    }

    private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Lightness();
      pictureBox1.Image = pic.GetPic();
    }

    private void standartToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Blur();
      pictureBox1.Image = pic.GetPic();
    }

    private void compareToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (pic.ComparePic(pic.GetPic(), new Bitmap(openFileDialog1.FileName)))
          throw new Exception("Eq img");
      }
    }

    private void adaptiveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.AdaptiveBin();
      pictureBox1.Image = pic.GetPic();
    }

    private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Threshold();
      pictureBox1.Image = pic.GetPic();
    }
  }
}
