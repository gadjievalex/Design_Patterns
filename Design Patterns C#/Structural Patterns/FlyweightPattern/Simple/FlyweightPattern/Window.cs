using System.Windows.Forms;

namespace FlyweightPattern
{
    public class Window:Form
    {
        public Window()
        {
            this.Height = 600;
            this.Width = 600;
            this.Text = "Picture Groups";
            Client client = new Client();
            client.LoadGroups();
            this.Paint += new PaintEventHandler(client.DisplayGroups);
        }
    }
}
