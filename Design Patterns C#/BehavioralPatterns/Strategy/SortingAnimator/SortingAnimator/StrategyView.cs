using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAnimator
{
    class StrategyView<T>:Form where T:IComparable<T>
    {
        PictureBox pb;

        Func<IEnumerable<T>> Generator;

        public StrategyView(Func<IEnumerable<T>>generator)
        {
            Generator = generator;

            this.SuspendLayout();
            this.Text = "Sort Comparer";
            pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.BackColor = Color.White;
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);

            TableLayoutPanel p = new TableLayoutPanel();
            p.RowCount = 1;
            p.ColumnCount = 3;
            p.Dock = DockStyle.Top;
            this.Controls.Add(p);

            Button b = new Button();
            b.Name = "LargeItems";
            b.Click+=new EventHandler(ButtonClick);
            b.Text = "Objects";
            p.Controls.Add(b);

            b = new Button();
            b.Name = "SmalleItem";
            b.Click += new EventHandler(ButtonClick);
            b.Text = "Primitive";
            p.Controls.Add(b);

            b = new Button();
            b.Name = "ReversedList";
            b.Click += new EventHandler(ButtonClick);
            p.Controls.Add(b);

            p.Height = b.Height + 4;
            this.DoubleBuffered = true;
            this.ResumeLayout(true);
        }

        public void DrawGraph(IEnumerable<T>list)
        {
            if(pb.Image==null)
            {
                pb.Image = new Bitmap(pb.Width, pb.Height);
            }
            Graphics g = Graphics.FromImage(pb.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Blue, 19, 19, 202, 202);
            g.Dispose();
            Bitmap b = pb.Image as Bitmap;

            int listSize = list.Count();
            int x = 0;

            foreach(T item in list)
            {
                int? val = item as int?;

                if(!val.HasValue)
                {
                    val = 0;
                }
                b.SetPixel(x + 20, 20 + 200 - ((int)val), Color.Black);
                x++;
            }
            this.Refresh();
            Thread.Sleep(500);
            Application.DoEvents();
        }

        static SortStrategy<T>SelectStartegy(string name)
        {
            switch(name)
            {
                case "LargeItems":
                    return new MergeSorter<T>();
                case "SmalleItem":
                    return new QuickSorter<T>();
                case "ReversedList":
                    return new MergeSorter<T>();
                default:
                    return null;
            }
        }

        void ButtonClick(object sender, EventArgs e)
        {
            Button control = sender as Button;
            SortStrategy<T> strategy = SelectStartegy(control.Name);
            IEnumerable<T> newlist = Generator();
            DrawGraph(newlist);
            
            if(strategy==null)
            {
                return;
            }

            strategy.UpdateUI += new Action<IEnumerable<T>>(DrawGraph);
            strategy.Sort(newlist);
        }
    }
}
