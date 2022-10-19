using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterMax.Forms
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(f);
            this.panel_main.Tag = f;
            f.Show();
        }

        private void btn_images_Click(object sender, EventArgs e)
        {
            loadform(new form_images());
        }

        private void btn_camera_Click(object sender, EventArgs e)
        {
            loadform(new form_camera());
        }

        private void form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            loadform(new form_videos());
        }
    }
}
