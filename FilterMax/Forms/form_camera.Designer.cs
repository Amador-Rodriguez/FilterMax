namespace FilterMax.Forms
{
    partial class form_camera
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
            this.cb_camera = new System.Windows.Forms.ComboBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.rb_movement = new System.Windows.Forms.RadioButton();
            this.rb_faces = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_objects = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_camera
            // 
            this.cb_camera.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cb_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_camera.FormattingEnabled = true;
            this.cb_camera.Location = new System.Drawing.Point(1156, 591);
            this.cb_camera.Name = "cb_camera";
            this.cb_camera.Size = new System.Drawing.Size(148, 21);
            this.cb_camera.TabIndex = 0;
            this.cb_camera.SelectedIndexChanged += new System.EventHandler(this.cb_camera_SelectedIndexChanged);
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.Transparent;
            this.pb_image.Location = new System.Drawing.Point(346, 40);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(958, 507);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            // 
            // rb_movement
            // 
            this.rb_movement.AutoSize = true;
            this.rb_movement.BackColor = System.Drawing.Color.Transparent;
            this.rb_movement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_movement.ForeColor = System.Drawing.Color.White;
            this.rb_movement.Location = new System.Drawing.Point(361, 578);
            this.rb_movement.Name = "rb_movement";
            this.rb_movement.Size = new System.Drawing.Size(171, 24);
            this.rb_movement.TabIndex = 5;
            this.rb_movement.TabStop = true;
            this.rb_movement.Text = "Movement detection";
            this.rb_movement.UseVisualStyleBackColor = false;
            this.rb_movement.CheckedChanged += new System.EventHandler(this.rb_movement_CheckedChanged);
            // 
            // rb_faces
            // 
            this.rb_faces.AutoSize = true;
            this.rb_faces.BackColor = System.Drawing.Color.Transparent;
            this.rb_faces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_faces.ForeColor = System.Drawing.Color.White;
            this.rb_faces.Location = new System.Drawing.Point(361, 601);
            this.rb_faces.Name = "rb_faces";
            this.rb_faces.Size = new System.Drawing.Size(133, 24);
            this.rb_faces.TabIndex = 5;
            this.rb_faces.TabStop = true;
            this.rb_faces.Text = "Face detection";
            this.rb_faces.UseVisualStyleBackColor = false;
            this.rb_faces.CheckedChanged += new System.EventHandler(this.rb_faces_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(592, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Faces:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(679, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Objects on movement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(655, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(852, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1152, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Camera devices:";
            // 
            // rb_objects
            // 
            this.rb_objects.AutoSize = true;
            this.rb_objects.BackColor = System.Drawing.Color.Transparent;
            this.rb_objects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_objects.ForeColor = System.Drawing.Color.White;
            this.rb_objects.Location = new System.Drawing.Point(361, 624);
            this.rb_objects.Name = "rb_objects";
            this.rb_objects.Size = new System.Drawing.Size(151, 24);
            this.rb_objects.TabIndex = 5;
            this.rb_objects.TabStop = true;
            this.rb_objects.Text = "Objects detection";
            this.rb_objects.UseVisualStyleBackColor = false;
            this.rb_objects.CheckedChanged += new System.EventHandler(this.rb_objects_CheckedChanged);
            // 
            // form_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilterMax.Properties.Resources.layout6;
            this.ClientSize = new System.Drawing.Size(1350, 715);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_objects);
            this.Controls.Add(this.rb_faces);
            this.Controls.Add(this.rb_movement);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.cb_camera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_camera";
            this.Text = "form_camera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_camera_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_camera;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.RadioButton rb_movement;
        private System.Windows.Forms.RadioButton rb_faces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_objects;
    }
}