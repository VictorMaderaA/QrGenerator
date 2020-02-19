using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrGenerator
{
    public class SaveImage
    {

        public static void Save(Bitmap bitmap)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName, ImageFormat.Png);
            }
        }

    }
}
