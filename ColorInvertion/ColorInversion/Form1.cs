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
        Bitmap bmp;
        Bitmap start_image;
        Bitmap previous_image;
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files | *.pmg; *.jpg; *.bmp; | All Files (*.*) | *.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                bmp = new Bitmap(filename);
                start_image = new Bitmap(filename);
                previous_image = new Bitmap(filename);
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            previous_image = bmp;
            bmp = ((Filters)e.Argument).processImage(bmp, backgroundWorker1);
            if (backgroundWorker1.CancellationPending)
                e.Cancel = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            progressBar1.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеГаусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sepia();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гистограммаИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hist = new Hist(bmp);
            hist.Show();
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(0);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void lightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(1);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void luminosityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(2);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void photoshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void iTURBT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(4);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void maxRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void minRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(6);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void somethingAlseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter(7);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bmp = previous_image;
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bmp = start_image;
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void стандартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new StandartBlackWhiteFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
