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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sobel = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_pixelate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_noiseHD = new System.Windows.Forms.Button();
            this.btn_noise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_grayScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(348, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FilterMax.Properties.Resources.ic_play1;
            this.pictureBox2.Location = new System.Drawing.Point(836, 519);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::FilterMax.Properties.Resources.ic_next1;
            this.pictureBox4.Location = new System.Drawing.Point(891, 525);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::FilterMax.Properties.Resources.ic_next2;
            this.pictureBox3.Location = new System.Drawing.Point(793, 525);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
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
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
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
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(370, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 17;
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
            this.cb_sobel.Location = new System.Drawing.Point(368, 628);
            this.cb_sobel.Name = "cb_sobel";
            this.cb_sobel.Size = new System.Drawing.Size(114, 24);
            this.cb_sobel.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(846, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Pixelate";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_pixelate
            // 
            this.btn_pixelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_pixelate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pixelate.FlatAppearance.BorderSize = 0;
            this.btn_pixelate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pixelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_pixelate.ForeColor = System.Drawing.Color.White;
            this.btn_pixelate.Location = new System.Drawing.Point(608, 590);
            this.btn_pixelate.Name = "btn_pixelate";
            this.btn_pixelate.Size = new System.Drawing.Size(114, 28);
            this.btn_pixelate.TabIndex = 8;
            this.btn_pixelate.Text = "Pixelate";
            this.btn_pixelate.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(846, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Noise HD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(726, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Random noise";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_noiseHD
            // 
            this.btn_noiseHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_noiseHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_noiseHD.FlatAppearance.BorderSize = 0;
            this.btn_noiseHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noiseHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_noiseHD.ForeColor = System.Drawing.Color.White;
            this.btn_noiseHD.Location = new System.Drawing.Point(608, 627);
            this.btn_noiseHD.Name = "btn_noiseHD";
            this.btn_noiseHD.Size = new System.Drawing.Size(114, 28);
            this.btn_noiseHD.TabIndex = 11;
            this.btn_noiseHD.Text = "Noise HD";
            this.btn_noiseHD.UseVisualStyleBackColor = false;
            // 
            // btn_noise
            // 
            this.btn_noise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_noise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_noise.FlatAppearance.BorderSize = 0;
            this.btn_noise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_noise.ForeColor = System.Drawing.Color.White;
            this.btn_noise.Location = new System.Drawing.Point(488, 627);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(114, 28);
            this.btn_noise.TabIndex = 12;
            this.btn_noise.Text = "Random noise";
            this.btn_noise.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(726, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Grayscale";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_negative
            // 
            this.btn_negative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_negative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_negative.FlatAppearance.BorderSize = 0;
            this.btn_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_negative.ForeColor = System.Drawing.Color.White;
            this.btn_negative.Location = new System.Drawing.Point(368, 590);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(114, 28);
            this.btn_negative.TabIndex = 14;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = false;
            // 
            // btn_grayScale
            // 
            this.btn_grayScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_grayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_grayScale.FlatAppearance.BorderSize = 0;
            this.btn_grayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_grayScale.ForeColor = System.Drawing.Color.White;
            this.btn_grayScale.Location = new System.Drawing.Point(488, 590);
            this.btn_grayScale.Name = "btn_grayScale";
            this.btn_grayScale.Size = new System.Drawing.Size(114, 28);
            this.btn_grayScale.TabIndex = 15;
            this.btn_grayScale.Text = "Grayscale";
            this.btn_grayScale.UseVisualStyleBackColor = false;
            // 
            // form_videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.ClientSize = new System.Drawing.Size(1350, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sobel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_pixelate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_noiseHD);
            this.Controls.Add(this.btn_noise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_negative);
            this.Controls.Add(this.btn_grayScale);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_videos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sobel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_pixelate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_noiseHD;
        private System.Windows.Forms.Button btn_noise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button btn_grayScale;
    }
}