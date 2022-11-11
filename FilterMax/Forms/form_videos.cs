using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FilterMax.Forms
{
    public partial class form_videos : Form
    {
        VideoCapture videoCapture;
        bool isPLaying = false;
        int totalFrames;
        int currentFrameNo;
        Mat currentFrame;
        int FPS;

        enum CurrentFilter
        {
            none = 0,
            grayScale = 1,
            negative = 2,
            pixelate = 3,
            noise= 4
        }

        CurrentFilter currentFilter= CurrentFilter.none;

        public form_videos()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (* .mp4, *.flv) |  *.mp4; *.flv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(ofd.FileName);
                totalFrames = Convert.ToInt32(videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
                FPS = Convert.ToInt32(videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                isPLaying = true;
                currentFrame = new Mat();
                currentFrameNo = 0;
                trackBar1.Minimum = 0;
                trackBar1.Maximum = totalFrames-1;
                trackBar1.Value = 0;
                playVideo();
            }
        }

        private async void playVideo()
        {
            if(videoCapture== null)
            {
                return;
            }

            try
            {
                while (isPLaying && currentFrameNo < totalFrames)
                {
                    videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, currentFrameNo);
                    videoCapture.Read(currentFrame);

                    switch (currentFilter)
                    {
                        case CurrentFilter.none:
                            {
                                pb_video.Image = currentFrame.Bitmap;
                                break;
                            }
                        case CurrentFilter.grayScale:
                            {
                                grayscaleFilter(currentFrame.Bitmap);
                                break;
                            }
                        case CurrentFilter.pixelate:
                            {
                                pixelateFilter(currentFrame.Bitmap);
                                break;
                            }
                        case CurrentFilter.negative:
                            {
                                negativeFilter(currentFrame.Bitmap);
                                break;
                            }
                            case CurrentFilter.noise:
                            {
                                noiseFilter(currentFrame.Bitmap);
                                break;
                            }
                    }

                    trackBar1.Value = currentFrameNo;
                    currentFrameNo++;
                    await Task.Delay(1000/FPS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                isPLaying = true;
                playVideo();
            }
            else
            {
                isPLaying = false;
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            isPLaying=false;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            isPLaying=false;
            currentFrameNo = 0;
            trackBar1.Value = 0;
            pb_video.Image = null;
            pb_video.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                currentFrameNo = trackBar1.Value;
            }
        }

        private void grayscaleFilter(Bitmap frame)
        {
            int x = 0;
            int y = 0;

            Bitmap result = new Bitmap(frame.Width, frame.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float pixelsCount = 0;
            float porcentaje = 0;
            float size = frame.Width * frame.Height;

            float g = 0;

            for (x = 0; x < frame.Width; x++)
            {
                for (y = 0; y < frame.Height; y++)
                {
                    oColor = frame.GetPixel(x, y);

                    // 0.2126 0.7152 0.0722 // Colorimetrica basada en la precepción humana 
                    // 0.299 0.587 0.114 // Luma, basado en brillo
                    // 0.267 0.678 0.0593
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);
                    result.SetPixel((int)x, (int)y, rColor);

                    pixelsCount += 1;

                }
                porcentaje = ((pixelsCount * 100) / size);
                
            }
            pb_video.Image = result;
        }

        private void pixelateFilter(Bitmap frame)
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
            float size = frame.Width * frame.Height;

            Bitmap result = new Bitmap(frame.Width, frame.Height);
            for (x = 0; x < frame.Width - tile; x += tile)
            {
                for (y = 0; y < frame.Height - tile; y += tile)
                {
                    rs = 0;
                    gs = 0;
                    bs = 0;

                    for (xt = x; xt < (x + tile); xt++)
                    {
                        for (yt = y; yt < (y + tile); yt++)
                        {
                            oColor = frame.GetPixel(xt, yt);
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
            }
            porcentaje = 100;

            pb_video.Image = result;

        }

        private void negativeFilter(Bitmap frame)
        {

            int x = 0;
            int y = 0;
            Bitmap result = new Bitmap(frame.Width, frame.Height);
            Color rColor = new Color();
            Color oColor = new Color();
            float pixelsCount = 0;
            float porcentaje;
            float size = frame.Width * frame.Height;


            for (x = 0; x < frame.Width; x++)
            {
                for (y = 0; y < frame.Height; y++)
                {
                    oColor = frame.GetPixel(x, y);
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);
                    result.SetPixel(x, y, rColor);
                    pixelsCount += 1;

                }

                porcentaje = ((pixelsCount * 100) / size);
               
            }
            pb_video.Image = result;

        }

        private void noiseFilter(Bitmap frame)
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
            float size = frame.Width * frame.Height;

            Bitmap result = new Bitmap(frame.Width, frame.Height);
            for (x = 0; x < frame.Width; x++)
            {
                for (y = 0; y < frame.Height; y++)
                {
                    if (rnd.Next(1, 100) <= scale)
                    {
                        rColor = Color.FromArgb(rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax),
                                                                 rnd.Next(rangeMin, rangeMax));
                    }
                    else
                    {
                        rColor = frame.GetPixel(x, y);
                    }
                    pixelsCount += 1;
                    result.SetPixel(x, y, rColor);
                }
            }
            pb_video.Image = result;
        }

        private void btn_grayScale_Click(object sender, EventArgs e)
        {
            currentFilter = CurrentFilter.grayScale;
        }

        private void form_videos_FormClosing(object sender, FormClosingEventArgs e)
        {
            isPLaying = false;
            currentFrameNo = 0;
            trackBar1.Value = 0;
            pb_video.Image = null;
            pb_video.Invalidate();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentFilter = CurrentFilter.none;
        }

        private void btn_pixelate_Click(object sender, EventArgs e)
        {
            currentFilter = CurrentFilter.pixelate;
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            currentFilter= CurrentFilter.negative;
        }

        private void btn_noise_Click(object sender, EventArgs e)
        {
            currentFilter = CurrentFilter.noise;
        }
    }
}
