using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ColorInversion
{
    public partial class Hist : Form
    {
        private Bitmap bmp;
        int[] his_intensity;
        int[] red_intensity;
        int[] green_intensity;
        int[] blue_intensity;
        
        public Hist(Bitmap _bmp)
        {
            InitializeComponent();
            bmp = _bmp;
            his_intensity = new int[256];
            red_intensity = new int[256];
            green_intensity = new int[256];
            blue_intensity = new int[256];
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Hist_Load(object sender, EventArgs e)
        {
            YValue();
            for (int i = 0; i < 256; i++)
            {
                chart.Series[0].Points.AddXY(i + 1, (double)his_intensity[i] / (bmp.Height * bmp.Width));
                chart1.Series[0].Points.AddXY(i + 1, (double)red_intensity[i] / (bmp.Height * bmp.Width));
                chart2.Series[0].Points.AddXY(i + 1, (double)green_intensity[i] / (bmp.Height * bmp.Width));
                chart3.Series[0].Points.AddXY(i + 1, (double)blue_intensity[i] / (bmp.Height * bmp.Width));
            }
            chart.Invalidate();
        }

        private void YValue()
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    red_intensity[color.R]++;
                    green_intensity[color.G]++;
                    blue_intensity[color.B]++;
                    int Intensity = (int)((color.R + color.G + color.B) / 3);
                    his_intensity[Intensity]++;
                }
        }
    }
}
