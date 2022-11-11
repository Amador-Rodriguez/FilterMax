namespace FilterMax.Forms
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
            this.panel_h_red = new System.Windows.Forms.Panel();
            this.btn_histograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagebox)).BeginInit();
            this.panel_filters.SuspendLayout();
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
            this.pb_imagebox.Visible = false;
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
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes BMP|*.bmp| Imagenes JPG|*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
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
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // btn_grayScale
            // 
            this.btn_grayScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_grayScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_grayScale.FlatAppearance.BorderSize = 0;
            this.btn_grayScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_grayScale.ForeColor = System.Drawing.Color.White;
            this.btn_grayScale.Location = new System.Drawing.Point(396, 57);
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
            this.btn_negative.Location = new System.Drawing.Point(38, 58);
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
            this.btn_pixelate.Location = new System.Drawing.Point(636, 57);
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
            this.panel_filters.Controls.Add(this.btn_pixelate);
            this.panel_filters.Controls.Add(this.btn_noiseHD);
            this.panel_filters.Controls.Add(this.btn_noise);
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
            this.label1.Location = new System.Drawing.Point(158, 64);
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
            this.cb_sobel.Location = new System.Drawing.Point(156, 61);
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
            this.btn_noiseHD.Location = new System.Drawing.Point(516, 57);
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
            this.btn_noise.Location = new System.Drawing.Point(276, 57);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(114, 28);
            this.btn_noise.TabIndex = 1;
            this.btn_noise.Text = "Random noise";
            this.btn_noise.UseVisualStyleBackColor = false;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // panel_h_red
            // 
            this.panel_h_red.Location = new System.Drawing.Point(26, 308);
            this.panel_h_red.Name = "panel_h_red";
            this.panel_h_red.Size = new System.Drawing.Size(280, 280);
            this.panel_h_red.TabIndex = 4;
            // 
            // btn_histograma
            // 
            this.btn_histograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_histograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_histograma.FlatAppearance.BorderSize = 0;
            this.btn_histograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_histograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_histograma.ForeColor = System.Drawing.Color.White;
            this.btn_histograma.Location = new System.Drawing.Point(26, 594);
            this.btn_histograma.Name = "btn_histograma";
            this.btn_histograma.Size = new System.Drawing.Size(280, 28);
            this.btn_histograma.TabIndex = 1;
            this.btn_histograma.Text = "Histogram";
            this.btn_histograma.UseVisualStyleBackColor = false;
            this.btn_histograma.Click += new System.EventHandler(this.btn_histograma_Click);
            // 
            // form_images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_h_red);
            this.Controls.Add(this.panel_filters);
            this.Controls.Add(this.pbar_process);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pb_imagebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_images";
            this.Text = "form_images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_images_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagebox)).EndInit();
            this.panel_filters.ResumeLayout(false);
            this.panel_filters.PerformLayout();
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
        private System.Windows.Forms.Panel panel_h_red;
        private System.Windows.Forms.Button btn_histograma;
    }
}