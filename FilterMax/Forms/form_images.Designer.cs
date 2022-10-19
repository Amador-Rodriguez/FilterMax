﻿namespace FilterMax.Forms
{
    partial class form_images
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_imagebox = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbar_process = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_grayScale = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_pixelate = new System.Windows.Forms.Button();
            this.panel_filters = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sobel = new System.Windows.Forms.ComboBox();
            this.btn_noiseHD = new System.Windows.Forms.Button();
            this.btn_noise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagebox)).BeginInit();
            this.panel_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_imagebox
            // 
            this.pb_imagebox.BackColor = System.Drawing.Color.Transparent;
            this.pb_imagebox.Location = new System.Drawing.Point(408, 44);
            this.pb_imagebox.Name = "pb_imagebox";
            this.pb_imagebox.Size = new System.Drawing.Size(844, 436);
            this.pb_imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagebox.TabIndex = 0;
            this.pb_imagebox.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(1174, 580);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(114, 28);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load image";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1174, 614);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(114, 28);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(1174, 648);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(114, 28);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes BMP|*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // pbar_process
            // 
            this.pbar_process.ForeColor = System.Drawing.Color.Red;
            this.pbar_process.Location = new System.Drawing.Point(408, 470);
            this.pbar_process.Name = "pbar_process";
            this.pbar_process.Size = new System.Drawing.Size(844, 10);
            this.pbar_process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar_process.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn_grayScale
            // 
            this.btn_grayScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_grayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_grayScale.FlatAppearance.BorderSize = 0;
            this.btn_grayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_grayScale.ForeColor = System.Drawing.Color.White;
            this.btn_grayScale.Location = new System.Drawing.Point(140, 23);
            this.btn_grayScale.Name = "btn_grayScale";
            this.btn_grayScale.Size = new System.Drawing.Size(114, 28);
            this.btn_grayScale.TabIndex = 1;
            this.btn_grayScale.Text = "Grayscale";
            this.btn_grayScale.UseVisualStyleBackColor = false;
            this.btn_grayScale.Click += new System.EventHandler(this.btn_grayScale_Click);
            // 
            // btn_negative
            // 
            this.btn_negative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_negative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_negative.FlatAppearance.BorderSize = 0;
            this.btn_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_negative.ForeColor = System.Drawing.Color.White;
            this.btn_negative.Location = new System.Drawing.Point(20, 23);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(114, 28);
            this.btn_negative.TabIndex = 1;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = false;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_pixelate
            // 
            this.btn_pixelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_pixelate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pixelate.FlatAppearance.BorderSize = 0;
            this.btn_pixelate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pixelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_pixelate.ForeColor = System.Drawing.Color.White;
            this.btn_pixelate.Location = new System.Drawing.Point(260, 23);
            this.btn_pixelate.Name = "btn_pixelate";
            this.btn_pixelate.Size = new System.Drawing.Size(114, 28);
            this.btn_pixelate.TabIndex = 1;
            this.btn_pixelate.Text = "Pixelate";
            this.btn_pixelate.UseVisualStyleBackColor = false;
            this.btn_pixelate.Click += new System.EventHandler(this.btn_pixelate_Click);
            // 
            // panel_filters
            // 
            this.panel_filters.BackColor = System.Drawing.Color.Transparent;
            this.panel_filters.Controls.Add(this.label1);
            this.panel_filters.Controls.Add(this.cb_sobel);
            this.panel_filters.Controls.Add(this.button4);
            this.panel_filters.Controls.Add(this.btn_pixelate);
            this.panel_filters.Controls.Add(this.button3);
            this.panel_filters.Controls.Add(this.button2);
            this.panel_filters.Controls.Add(this.btn_noiseHD);
            this.panel_filters.Controls.Add(this.btn_noise);
            this.panel_filters.Controls.Add(this.button1);
            this.panel_filters.Controls.Add(this.btn_negative);
            this.panel_filters.Controls.Add(this.btn_grayScale);
            this.panel_filters.Enabled = false;
            this.panel_filters.Location = new System.Drawing.Point(343, 557);
            this.panel_filters.Name = "panel_filters";
            this.panel_filters.Size = new System.Drawing.Size(791, 142);
            this.panel_filters.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sobel         ";
            // 
            // cb_sobel
            // 
            this.cb_sobel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.cb_sobel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_sobel.ForeColor = System.Drawing.Color.White;
            this.cb_sobel.FormattingEnabled = true;
            this.cb_sobel.Items.AddRange(new object[] {
            "Sobel 0",
            "Sobel 1",
            "Sobel 2",
            "Sobel 3",
            "Sobel 4",
            "Sobel 5",
            "Sobel 6",
            "Sobel 7"});
            this.cb_sobel.Location = new System.Drawing.Point(20, 61);
            this.cb_sobel.Name = "cb_sobel";
            this.cb_sobel.Size = new System.Drawing.Size(114, 24);
            this.cb_sobel.TabIndex = 2;
            this.cb_sobel.SelectedIndexChanged += new System.EventHandler(this.cb_sobel_SelectedIndexChanged);
            // 
            // btn_noiseHD
            // 
            this.btn_noiseHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_noiseHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_noiseHD.FlatAppearance.BorderSize = 0;
            this.btn_noiseHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noiseHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_noiseHD.ForeColor = System.Drawing.Color.White;
            this.btn_noiseHD.Location = new System.Drawing.Point(260, 60);
            this.btn_noiseHD.Name = "btn_noiseHD";
            this.btn_noiseHD.Size = new System.Drawing.Size(114, 28);
            this.btn_noiseHD.TabIndex = 1;
            this.btn_noiseHD.Text = "Noise HD";
            this.btn_noiseHD.UseVisualStyleBackColor = false;
            this.btn_noiseHD.Click += new System.EventHandler(this.btn_noiseHD_Click);
            // 
            // btn_noise
            // 
            this.btn_noise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_noise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_noise.FlatAppearance.BorderSize = 0;
            this.btn_noise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_noise.ForeColor = System.Drawing.Color.White;
            this.btn_noise.Location = new System.Drawing.Point(140, 60);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(114, 28);
            this.btn_noise.TabIndex = 1;
            this.btn_noise.Text = "Random noise";
            this.btn_noise.UseVisualStyleBackColor = false;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Grayscale";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_grayScale_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(378, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Random noise";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(498, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Noise HD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_noiseHD_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(498, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Pixelate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_pixelate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilterMax.Properties.Resources.histograma;
            this.pictureBox1.Location = new System.Drawing.Point(34, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // form_images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_filters);
            this.Controls.Add(this.pbar_process);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pb_imagebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_images";
            this.Text = "form_images";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagebox)).EndInit();
            this.panel_filters.ResumeLayout(false);
            this.panel_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_imagebox;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar pbar_process;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_grayScale;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button btn_pixelate;
        private System.Windows.Forms.Panel panel_filters;
        private System.Windows.Forms.ComboBox cb_sobel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_noiseHD;
        private System.Windows.Forms.Button btn_noise;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}