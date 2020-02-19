using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrGenerator
{
    public class QrGenerator
    {

        public static Bitmap GenerateQr(int size, string text)
        {
            if (size <= 0 || string.IsNullOrEmpty(text)) return null;

            var bw = new ZXing.BarcodeWriter();
            var encOptions = new ZXing.Common.EncodingOptions() { Width = size, Height = size, Margin = 0 };
            bw.Options = encOptions;
            bw.Format = ZXing.BarcodeFormat.QR_CODE;
            var result = new Bitmap(bw.Write(text));
            return result;
        }

    }
}
