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

    private void button1_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        pic = new GGC(new Bitmap(openFileDialog1.FileName), openFileDialog1.FileName);
        pictureBox1.Image = pic.GetPic();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      pic.Inversion();
      pictureBox1.Image = pic.GetPic();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (pic == null)
        throw new Exception("Expect any image");

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        pic.GetPic().Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
      }
    }
  }
}
