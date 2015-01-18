using AbstractFactory.interfaces;

namespace AbstractFactory.Brands
{
    class Groundcover:IBrand
    {
        public int Price
        {
            get { return 2000; }
        }

        public string Material
        {
            get { return "leather"; }
        }
    }
}
