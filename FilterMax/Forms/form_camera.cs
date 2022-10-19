﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            movementDetection = 1,
            objectsDetection = 1,
        }
        private bool camera_available = false;
        private FilterInfoCollection devices;
        private VideoCaptureDevice videoCaptureDevice;

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
                        Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 1);
                        foreach (Rectangle rectangle in rectangles)
                        {
                            using (Graphics graphics = Graphics.FromImage(image))
                            {
                                using (Pen pen = new Pen(Color.Red, 1))
                                {
                                    graphics.DrawRectangle(pen, rectangle);
                                }
                            }
                        }
                        pb_image.Image = image;
                        break;

                    } 
                    case (CameraMode)2:
                    {
                        Bitmap box = image;
                        if (detector.ProcessFrame(box)> 1)
                        {
                            image = box;
                            pb_image.Image = image;
                        }
                        else
                        {
                            pb_image.Image = image;
                        }

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
            Application.Exit();
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
            detector = new MotionDetector(new SimpleBackgroundModelingDetector(), new BlobCountingObjectsProcessing());
            cameraMode = (CameraMode)3;

        }
    }
}