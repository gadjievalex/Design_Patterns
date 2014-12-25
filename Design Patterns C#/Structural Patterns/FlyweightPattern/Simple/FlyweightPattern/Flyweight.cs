using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlyweightPattern
{
    struct Flyweight:IFlyweight
    {
        Image pThumbnail;

        public void Load(string filename)
        {
            pThumbnail = new Bitmap("images/" + filename).GetThumbnailImage(100, 100, null, new IntPtr());
        }

        public void Dysplay(PaintEventArgs e, int row, int col)
        {
            int r = row;
            e.Graphics.DrawImage(pThumbnail, col * 100 + 10, row * 130 + 40, pThumbnail.Width, pThumbnail.Height);
        }
    }
}
