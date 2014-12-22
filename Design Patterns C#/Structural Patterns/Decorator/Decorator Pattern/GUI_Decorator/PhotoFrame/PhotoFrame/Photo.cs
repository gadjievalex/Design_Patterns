using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ConsoleApplication1
{
    class Photo:Form
    {
        Image image;

        public Photo()
        {
            image = new Bitmap("picture.jpg");
            
            this.Text = "Monkey";
            this.Paint += new PaintEventHandler(Drawer);
        }
        public virtual void Drawer(Object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0);
        }
    }
}
