namespace FilterMax.Forms
{
    partial class form_main
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_camera = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_images = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1350, 729);
            this.panel_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_camera);
            this.panel1.Controls.Add(this.btn_video);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_images);
            this.panel1.Location = new System.Drawing.Point(38, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 225);
            this.panel1.TabIndex = 0;
            // 
            // btn_camera
            // 
            this.btn_camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_camera.FlatAppearance.BorderSize = 0;
            this.btn_camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_camera.ForeColor = System.Drawing.Color.White;
            this.btn_camera.Location = new System.Drawing.Point(17, 174);
            this.btn_camera.Name = "btn_camera";
            this.btn_camera.Size = new System.Drawing.Size(209, 34);
            this.btn_camera.TabIndex = 0;
            this.btn_camera.Text = "CAMERA";
            this.btn_camera.UseVisualStyleBackColor = false;
            this.btn_camera.Click += new System.EventHandler(this.btn_camera_Click);
            // 
            // btn_video
            // 
            this.btn_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_video.ForeColor = System.Drawing.Color.White;
            this.btn_video.Location = new System.Drawing.Point(17, 120);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(209, 34);
            this.btn_video.TabIndex = 0;
            this.btn_video.Text = "VIDEOS";
            this.btn_video.UseVisualStyleBackColor = false;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(17, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_images
            // 
            this.btn_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(142)))));
            this.btn_images.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_images.FlatAppearance.BorderSize = 0;
            this.btn_images.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_images.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_images.ForeColor = System.Drawing.Color.White;
            this.btn_images.Location = new System.Drawing.Point(17, 69);
            this.btn_images.Name = "btn_images";
            this.btn_images.Size = new System.Drawing.Size(209, 34);
            this.btn_images.TabIndex = 0;
            this.btn_images.Text = "IMAGES";
            this.btn_images.UseVisualStyleBackColor = false;
            this.btn_images.Click += new System.EventHandler(this.btn_images_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_main_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_images;
        private System.Windows.Forms.Button btn_camera;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button button2;
    }
}