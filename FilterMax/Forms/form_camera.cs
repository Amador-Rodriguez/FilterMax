using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FilterMax.Forms
{
    public partial class form_camera : Form
    {
        private enum CameraMode
        {
            facesDetection = 1,
            movementDetection = 2,
            objectsDetection = 3,
        }
        private bool camera_available = false;
        private FilterInfoCollection devices;
        private VideoCaptureDevice videoCaptureDevice;
        BlobCountingObjectsProcessing processing = new BlobCountingObjectsProcessing();
        private CameraMode cameraMode;
        MotionDetector detector;
        float level;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public form_camera()
        {
            InitializeComponent();
            LoadDevices();
        }

        public void LoadDevices()
        {
            //detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());

            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (devices.Count > 0)
            {
                camera_available = true;
                for (int i = 0; i < devices.Count; i++)
                {
                    cb_camera.Items.Add(devices[i].Name);
                }
                //cb_camera.SelectedIndex = 0;
            }
            else
            {
                camera_available = false;
            }
        }

        public void closeCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice = null;
            }
        }

        private void cb_camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            closeCamera();
            int i = cb_camera.SelectedIndex;
            string nameDevice = devices[i].MonikerString;
            videoCaptureDevice = new VideoCaptureDevice(nameDevice);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(recording);
            videoCaptureDevice.Start();
        }

        private void recording(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone(); 

            switch (cameraMode)
            {
                case (CameraMode)1:
                    {
                        Image<Bgr, byte> grayImage = new Image<Bgr, byte>(image);
                        Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
                        foreach (Rectangle rectangle in rectangles)
                        {
                            Font font = new Font("Poppins", 25);

                            StringFormat format = new StringFormat();
                            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;

                            using (Graphics graphics = Graphics.FromImage(image))
                            {
                                using (Pen pen = new Pen(Color.Red, 1))
                                {
                                    SolidBrush brush = new SolidBrush(Color.Red);
                                    graphics.DrawRectangle(pen, rectangle);
                                    graphics.DrawString("Face", font, brush, rectangle.X, rectangle.Y - 10, format);

                                }
                            }
                        }
                        pb_image.Image = image;
                        break;

                    } 
                    case (CameraMode)2:
                    {
                        detector.ProcessFrame(image);
                        pb_image.Image = image;
                        break;
                    } 
                    case (CameraMode)3:
                    {
                        Bitmap box = (Bitmap)eventArgs.Frame.Clone();
                        level = detector.ProcessFrame(box);
                        if (level > 0.01)
                        {
                            Console.WriteLine(level.ToString());
                            image = box;
                            pb_image.Image = image;
                        }
                        else
                        {
                            pb_image.Image = image;
                        }
                        break;
                    } 

                
            };

            
        }

        public void form_camera_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeCamera();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_movement_CheckedChanged(object sender, EventArgs e)
        {
            detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            cameraMode = (CameraMode)2;
        }

        private void rb_faces_CheckedChanged(object sender, EventArgs e)
        {
            cameraMode = (CameraMode)1;
        }

        private void rb_objects_CheckedChanged(object sender, EventArgs e)
        {
            
            processing.HighlightMotionRegions = true;
            processing.MinObjectsWidth = 75;
            processing.MinObjectsHeight = 75;
            detector = new MotionDetector(new SimpleBackgroundModelingDetector(), processing);
            cameraMode = (CameraMode)3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_objects.Text = processing.ObjectsCount.ToString();
        }
    }
}
