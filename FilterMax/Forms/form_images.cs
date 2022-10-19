using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterMax.Forms
{
    public partial class form_images : Form
    {

        private Bitmap original;
        private Bitmap result;
        private int[] histogram = new int[256];
        private int[,] conv3x3 = new int[3,3];
        private int factor;
        private int offset;
        private int width, height;

        private int[] histograma = new int[256];


        public form_images()
        {
            InitializeComponent();
            result = new Bitmap(800, 600);
            width = 800;
            height = 600; 
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar_process.Value = e.ProgressPercentage;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetImage();
        }

        private  void btn_negative_Click(object sender, EventArgs e)
        {
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync(argument: "Negative");
            //}
            negativeFilter();
        }

        private void btn_grayScale_Click(object sender, EventArgs e)
        {
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync(argument: "Grayscale");
            //}
            grayscaleFilter();
        }

        private void btn_pixelate_Click(object sender, EventArgs e)
        {
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync(argument: "Pixelate");
            //}
            pixelateFilter();
        }

        private void cb_sobel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync(argument: cb_sobel.Text);
            //}
            //pbar_process.Value = 0;
            label1.Visible = false;
            filterSobel(cb_sobel.Text);
        }

        private void btn_noise_Click(object sender, EventArgs e)
        {
            noiseFilter();
        }

        private void btn_noiseHD_Click(object sender, EventArgs e)
        {
            noiseHDfilter();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void ConvGray(int[,] pMatrix, Bitmap pImage, int pInferior, int pSuperior)
        {
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            Color oColor;

            int suma = 0;

            for (x = 1; x < pImage.Width - 1; x++)
            {
                for (y = 1; y < pImage.Height - 1; y++)
                {
                    suma = 0;
                    for (a = -1; a < 2; a++)
                    {
                        for (b = -1; b < 2; b++)
                        {
                            oColor = pImage.GetPixel(x + a, y + b);
                            suma = suma + (oColor.R * pMatrix[a + 1, b + 1]);

                        }
                    }
                    if (suma < pInferior)
                    {
                        suma = 0;
                    }
                    else if (suma > pSuperior)
                    {
                        suma = 255;
                    }
                    result.SetPixel(x, y, Color.FromArgb(suma, suma, suma));
                }
            }
        }

        private void negativeFilter()
        {

            int x = 0;
            int y = 0;
            result = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float pixelsCount = 0;
            float porcentaje;
            float size = original.Width * original.Height;


            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);
                    result.SetPixel(x, y, rColor);
                    pixelsCount += 1;
                    
                }
                
                porcentaje = ((pixelsCount * 100) / size);
                backgroundWorker1.ReportProgress((int)porcentaje);
            }
            pb_imagebox.Image = result;

        }

        private void grayscaleFilter()
        {
            int x = 0;
            int y = 0;

            result = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float pixelsCount = 0;
            float porcentaje = 0;
            float size = original.Width * original.Height;

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    // 0.2126 0.7152 0.0722 // Colorimetrica basada en la precepción humana 
                    // 0.299 0.587 0.114 // Luma, basado en brillo
                    // 0.267 0.678 0.0593
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    result.SetPixel((int)x, (int)y, rColor);

                    pixelsCount += 1;
                    
                }
                porcentaje = ((pixelsCount * 100) / size);
                backgroundWorker1.ReportProgress((int)porcentaje);
            }
            pb_imagebox.Image = result;
        }

        private void pixelateFilter()
        {
            int x = 0;
            int y = 0;
            int tile = 16;
            int xt = 0;
            int yt = 0;

            Color rColor;
            Color oColor;

            int rs = 0;
            int gs = 0;
            int bs = 0;

            int r = 0;
            int g = 0;
            int b = 0;

            float pixelsCount = 0;
            float porcentaje = 0;
            float size = original.Width * original.Height;

            result = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width - tile; x += tile)
            {
                for (y = 0; y < original.Height - tile; y += tile)
                {
                    rs = 0;
                    gs = 0;
                    bs = 0;

                    for (xt = x; xt < (x + tile); xt++)
                    {
                        for (yt = y; yt < (y + tile); yt++)
                        {
                            oColor = original.GetPixel(xt, yt);
                            rs += oColor.R;
                            gs += oColor.G;
                            bs += oColor.B;
                        }
                    }
                    r = rs / (tile * tile);
                    g = gs / (tile * tile);
                    b = bs / (tile * tile);
                    rColor = Color.FromArgb(r, g, b);

                    for (xt = x; xt < (x + tile); xt++)
                    {
                        for (yt = y; yt < (y + tile); yt++)
                        {
                            result.SetPixel(xt, yt, rColor);
                        }
                    }
                    pixelsCount += 256;
                    
                }
                porcentaje = ((pixelsCount * 100) / size);
                backgroundWorker1.ReportProgress((int)porcentaje);
            }
            porcentaje = 100;
            backgroundWorker1.ReportProgress((int)porcentaje);

            pb_imagebox.Image = result;

        }

        private void filterSobel(string scale)
        {
            int[,] sobel;
            
            switch (scale)
            {
                case "Sobel 0":
                    {
                        sobel = new int[,]
                                        {{  1,   2,   1},
                                        {  0  , 0,   0},
                                        { -1, -2 ,-1}};
                        break;
                    }
                case "Sobel 1":
                    {
                        sobel = new int[,]
                                        {{  2,   1,   0},
                                        {   1,   0,   -1},
                                        {   0,  -1 , -2}};
                        break;
                    }
                case "Sobel 2":
                    {
                        sobel = new int[,]
                                        {{  1,   0,   -1},
                                        {   2,   0,   -2},
                                        {   1,   0 , -1}};
                        break;
                    }
                case "Sobel 3":
                    {
                        sobel = new int[,]
                                        {{  0,   -1,   -2},
                                        {   1,   0,   -1},
                                        {   2,   1 ,   0}};
                        break;
                    }
                case "Sobel 4":
                    {
                        sobel = new int[,]
                                        {{  -1,   -2,   -1},
                                        {   0,   0,   0},
                                        {   1,   2 ,   1}};
                        break;
                    }
                case "Sobel 5":
                    {
                        sobel = new int[,]
                                        {{  -2,   -1,   0},
                                        {   -1,   0,   1},
                                        {   0,   1 ,   2}};
                        break;
                        
                    }
                case "Sobel 6":
                    {
                        sobel = new int[,]
                                        {{  -1,   0,   1},
                                        {   -2,   0,   2},
                                        {   -1,   0 ,   1}};
                        break;
                    }
                case "Sobel 7":
                    {
                        sobel = new int[,]
                                        {{  0,   1,   2},
                                        {   -1,   0,   1},
                                        {   -2,   -1 ,   0}};
                        break;
                    }
                default:
                    {
                        sobel = new int[,]
                                       {{  1,   2,   1},
                                        {  0  , 0,   0},
                                        { -1, -2 ,-1}};
                        break;
                    }
            }

            grayscaleFilter();

            Bitmap intermedio = (Bitmap)result.Clone();
            ConvGray(sobel, intermedio, 0, 255);
            pb_imagebox.Image = result;

        }

        private void noiseFilter()
        {
            int x = 0;
            int y = 0;
            int scale = 15;
            int rangeMin = 85;
            int rangeMax = 115;
            float pBrillo = 0;

            Random rnd = new Random();
            Color rColor;
            Color oColor;

            int r = 0;
            int g = 0;
            int b = 0;

            float pixelsCount = 0;
            float porcentaje = 0;
            float size = original.Width * original.Height;

            result = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    if (rnd.Next(1, 100) <= scale)
                    {
                        rColor = Color.FromArgb(rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax));
                    }
                    else
                    {
                        rColor = original.GetPixel(x, y);
                    }
                    pixelsCount += 1;
                    result.SetPixel(x, y, rColor);
                }
                porcentaje = ((pixelsCount * 100) / size);
                backgroundWorker1.ReportProgress((int)porcentaje);
            }
            pb_imagebox.Image = result;
        }

        private void noiseHDfilter()
        {
            int x = 0;
            int y = 0;
            int scale = 25;
            int rangeMin = 90;
            int rangeMax = 140;
            float pBrillo = 0;

            Random rnd = new Random();
            Color rColor;
            Color oColor;

            int r = 0;
            int g = 0;
            int b = 0;

            float pixelsCount = 0;
            float porcentaje = 0;
            float size = original.Width * original.Height;

            result = new Bitmap(original.Width, original.Height);
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    if (rnd.Next(1, 100) <= scale)
                    {
                        rColor = Color.FromArgb(rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax));

                        pBrillo = rnd.Next(rangeMin, rangeMax) / 100.0f;
                        oColor = original.GetPixel(x, y);
                        r = (int)(oColor.R * pBrillo);
                        g = (int)(oColor.G * pBrillo);
                        b = (int)(oColor.B * pBrillo);
                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;
                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;
                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;
                        rColor = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        rColor = original.GetPixel(x, y);
                    }
                    pixelsCount += 1;
                    result.SetPixel(x, y, rColor);
                }
                porcentaje = ((pixelsCount * 100) / size);
                backgroundWorker1.ReportProgress((int)porcentaje);
            }
            pb_imagebox.Image = result;
        }

        private void loadImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                width = original.Width;
                height = original.Height;
                result = original;

                pb_imagebox.Image = result;
                panel_filters.Enabled = true;
            }
        }

        private void saveImage()
        {
            if (pb_imagebox.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    result.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        

        private void resetImage()
        {
            if (original != null)
            {
                pb_imagebox.Image = original;
            }
        }

    }
}
