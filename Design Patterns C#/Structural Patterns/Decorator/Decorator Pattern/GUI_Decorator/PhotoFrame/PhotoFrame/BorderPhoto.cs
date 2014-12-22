using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BorderPhoto:Photo
    {
        Photo photo;
        Color color;

        public BorderPhoto(Photo p, Color c)
        {
            photo = p;
            color = c;
        }
        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
        }
    }
}
