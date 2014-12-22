using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo();

            TaggedPhoto taggedPhoto;
            TaggedPhoto colorTaggedPhoto;
            TaggedPhoto tag;

            BorderPhoto composition;

            Application.Run(photo);
            //////////////////////////////////////////////////////////////////////////////
            taggedPhoto = new TaggedPhoto(photo, "Monkey");
            
            colorTaggedPhoto = new TaggedPhoto(taggedPhoto, "Tag from colorTahhedPhoto");
            
            composition = new BorderPhoto(colorTaggedPhoto, Color.Bisque);

            Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());

            Application.Run(composition);
            //////////////////////////////////////////////////////////////////////////////
            photo = new Photo();

            tag = new TaggedPhoto(photo, "Просто тег");

            composition = new BorderPhoto(tag, Color.BlueViolet);

            Application.Run(composition);

            Console.WriteLine(tag.ListTaggedPhotos());
            //////////////////////////////////////////////////////////////////////////////
            Console.ReadKey();
        }
    }
}
