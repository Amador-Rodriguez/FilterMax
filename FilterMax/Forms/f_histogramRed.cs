using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterMax.Forms
{
    public partial class f_histogramRed : Form
    {

        private int[] histogram_red;
        private int[] histogram_green;
        private int[] histogram_blue;
        private int max_r;
        private int max_g;
        private int max_b;

        public f_histogramRed(int[] pHistogram_r, int[] pHistogram_g, int[] pHistogram_b)
        {
            InitializeComponent();
            histogram_red = pHistogram_r;
            histogram_green = pHistogram_g;
            histogram_blue = pHistogram_b;

            max_r = 0;
            max_g = 0;
            max_b= 0;

            for (int i = 0; i < 256; i++)
            {
                if (histogram_red[i] > max_r)
                {
                    max_r = histogram_red[i];
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram_red[i] = (int)((float)histogram_red[i] / (float)max_r * 256.0f);
            }

            for (int i = 0; i < 256; i++)
            {
                if (histogram_blue[i] > max_b)
                {
                    max_b = histogram_blue[i];
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram_blue[i] = (int)((float)histogram_blue[i] / (float)max_b * 256.0f);
            }


            for (int i = 0; i < 256; i++)
            {
                if (histogram_green[i] > max_g)
                {
                    max_g = histogram_green[i];
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram_green[i] = (int)((float)histogram_green[i] / (float)max_g * 256.0f);
            }

        }

        private void f_histogramRed_Paint(object sender, PaintEventArgs e)
        {
            int height = 0;
            Graphics graphics = e.Graphics;
            Pen penR = new Pen(Color.Red);
            Pen penG = new Pen(Color.Green);
            Pen penB = new Pen(Color.Blue);
            Pen penAxis = new Pen(Color.Black);
            graphics.DrawLine(penAxis, 19, 271, 277, 271);
            graphics.DrawLine(penAxis, 19, 271, 19, 14);

            for (int i = 0; i < 256; i++)
            {
                graphics.DrawLine(penR, i+20, 270, i+20, 270 - histogram_red[i]);
                graphics.DrawLine(penG, i+20, 270, i+20, 270 - histogram_green[i]);
                graphics.DrawLine(penB, i+20, 270, i+20, 270 - histogram_blue[i]);
            }


        }
    }
}
