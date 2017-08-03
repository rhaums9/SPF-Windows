using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;
namespace SPF_Card_Creation_utility
{
    class MakeImage
    {
        public void Export(Visual g, string name)
        {
            {
                if (g == null)
                    return;

                Rect bounds = VisualTreeHelper.GetDescendantBounds(g);

                RenderTargetBitmap rtb = new RenderTargetBitmap((Int32)bounds.Width *2 , (Int32)bounds.Height *2, 192, 192, PixelFormats.Pbgra32);

                DrawingVisual dv = new DrawingVisual();

                using (DrawingContext dc = dv.RenderOpen())
                {
                    VisualBrush vb = new VisualBrush(g);
                    dc.DrawRectangle(vb, null, new Rect(new Point(), bounds.Size));
                }

                rtb.Render(dv);

                PngBitmapEncoder png = new PngBitmapEncoder();

                png.Frames.Add(BitmapFrame.Create(rtb));

                using (Stream stm = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +"\\Statis Pro Cards\\"+name + ".png"))
                {
                    png.Save(stm);
                }
            }
        }
    }
}
