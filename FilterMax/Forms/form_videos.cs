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
                    pb_video.Image = currentFrame.Bitmap;
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
    }
}
