using System.Windows.Forms;

namespace FlyweightPattern
{
    interface IFlyweight
    {
        void Load(string filename);
        void Dysplay(PaintEventArgs e, int row, int col);
    }
}
