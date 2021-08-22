using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Drawing;
using System.Drawing.Imaging;
 using System.Drawing.Drawing2D;

namespace app_1_test_menu_desplegable
{
    class Class1
    {

        



    public static void OutputGradientImage()
        {

            using (Bitmap bitmap = new Bitmap(100, 100)) // 100x100 pixels
            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, 100, 100),
                Color.Aqua,
                Color.FromArgb(10, 132, 225),
            LinearGradientMode.Horizontal))
        {
            brush.SetSigmaBellShape(0.5f);
            graphics.FillRectangle(brush, new Rectangle(0, 0, 100, 100));
            bitmap.Save("gradientImage.jpg", ImageFormat.Jpeg);
        }
    }
}
}
