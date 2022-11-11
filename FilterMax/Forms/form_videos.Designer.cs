namespace FilterMax.Forms
{
    partial class form_videos
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
            this.pb_video = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.PictureBox();
            this.btn_pause = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_pixelate = new System.Windows.Forms.Button();
            this.btn_noise = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_grayScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_video
            // 
            this.pb_video.BackColor = System.Drawing.Color.Transparent;
            this.pb_video.Location = new System.Drawing.Point(348, 37);
            this.pb_video.Name = "pb_video";
            this.pb_video.Size = new System.Drawing.Size(958, 425);
            this.pb_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_video.TabIndex = 0;
            this.pb_video.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 715);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Location = new System.Drawing.Point(348, 468);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(958, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Image = global::FilterMax.Properties.Resources.ic_play1;
            this.btn_play.Location = new System.Drawing.Point(836, 519);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(39, 35);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 3;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.Image = global::FilterMax.Properties.Resources.btn_stop;
            this.btn_stop.Location = new System.Drawing.Point(881, 519);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(39, 35);
            this.btn_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_stop.TabIndex = 3;
            this.btn_stop.TabStop = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.Image = global::FilterMax.Properties.Resources.btn_pause;
            this.btn_pause.Location = new System.Drawing.Point(791, 519);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(39, 35);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 3;
            this.btn_pause.TabStop = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(1174, 614);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(114, 28);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
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
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load video";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_pixelate
            // 
            this.btn_pixelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_pixelate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pixelate.FlatAppearance.BorderSize = 0;
            this.btn_pixelate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pixelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_pixelate.ForeColor = System.Drawing.Color.White;
            this.btn_pixelate.Location = new System.Drawing.Point(606, 614);
            this.btn_pixelate.Name = "btn_pixelate";
            this.btn_pixelate.Size = new System.Drawing.Size(114, 28);
            this.btn_pixelate.TabIndex = 8;
            this.btn_pixelate.Text = "Pixelate";
            this.btn_pixelate.UseVisualStyleBackColor = false;
            this.btn_pixelate.Click += new System.EventHandler(this.btn_pixelate_Click);
            // 
            // btn_noise
            // 
            this.btn_noise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_noise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_noise.FlatAppearance.BorderSize = 0;
            this.btn_noise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_noise.ForeColor = System.Drawing.Color.White;
            this.btn_noise.Location = new System.Drawing.Point(726, 614);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(114, 28);
            this.btn_noise.TabIndex = 12;
            this.btn_noise.Text = "Random noise";
            this.btn_noise.UseVisualStyleBackColor = false;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // btn_negative
            // 
            this.btn_negative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_negative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_negative.FlatAppearance.BorderSize = 0;
            this.btn_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_negative.ForeColor = System.Drawing.Color.White;
            this.btn_negative.Location = new System.Drawing.Point(366, 614);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(114, 28);
            this.btn_negative.TabIndex = 14;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = false;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_grayScale
            // 
            this.btn_grayScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_grayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_grayScale.FlatAppearance.BorderSize = 0;
            this.btn_grayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_grayScale.ForeColor = System.Drawing.Color.White;
            this.btn_grayScale.Location = new System.Drawing.Point(486, 614);
            this.btn_grayScale.Name = "btn_grayScale";
            this.btn_grayScale.Size = new System.Drawing.Size(114, 28);
            this.btn_grayScale.TabIndex = 15;
            this.btn_grayScale.Text = "Grayscale";
            this.btn_grayScale.UseVisualStyleBackColor = false;
            this.btn_grayScale.Click += new System.EventHandler(this.btn_grayScale_Click);
            // 
            // form_videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.ClientSize = new System.Drawing.Size(1350, 715);
            this.Controls.Add(this.btn_pixelate);
            this.Controls.Add(this.btn_noise);
            this.Controls.Add(this.btn_negative);
            this.Controls.Add(this.btn_grayScale);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pb_video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_videos";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_videos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_video;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_stop;
        private System.Windows.Forms.PictureBox btn_pause;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_pixelate;
        private System.Windows.Forms.Button btn_noise;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button btn_grayScale;
    }
}