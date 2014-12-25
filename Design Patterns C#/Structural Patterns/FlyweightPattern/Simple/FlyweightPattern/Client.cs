using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlyweightPattern
{
    class Client
    {
        static FlyweightFactory album = new FlyweightFactory();

        static Dictionary<string, List<string>> allGroups = new Dictionary<string, List<string>>();

        public void LoadGroups()
        {
            var myGroups = new[]
            {
                new 
                {Name="Garden",Members=new []{"pot.jpg","spring.jpg","barbeque.jpg","flowers.jpg"}},
                new
                {Name="Italy",Members=new []{"capuchino.jpg","pasta.jpg","restaurant.jpg","church.jpg"}},
                new
                {Name="Food",Members=new []{"capuchino.jpg","pasta.jpg","barbeque.jpg","lemonade.jpg"}},
                new
                {Name="Friends",Members=new []{"restaurant.jpg","diner.jpg"}},
            };

            foreach (var g in myGroups)
            {
                allGroups.Add(g.Name, new List<string>());

                foreach (string filename in g.Members)
                {
                    allGroups[g.Name].Add(filename);
                    album[filename].Load(filename);
                }
            }
        }

        public void DisplayGroups(object source, PaintEventArgs e)
        {
            int row = 0;

            foreach(string g in allGroups.Keys)
            {
                int col = 0;

                e.Graphics.DrawString(g, new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(0, row * 130 + 10));

                foreach(string fileName in allGroups[g])
                {
                    album[fileName].Dysplay(e, row, col);
                    col++;
                }
                row++;
            }
        }
    }
}
