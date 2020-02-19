using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmap = null;

        private void btn_generate_Click(object sender, EventArgs e)
        {
            bitmap = QrGenerator.GenerateQr((int)num_size.Value, txt_content.Text);
            if (bitmap != null)
                setPicbox(bitmap);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(bitmap != null)
                SaveImage.Save(bitmap);
        }


        private void setPicbox(Bitmap image)
        {
            picbox.Image = bitmap;
        }
    }
}
