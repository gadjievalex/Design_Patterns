using AbstractFactory.interfaces;

namespace AbstractFactory.Brands
{
    class Gucci:IBrand
    {
        public int Price
        {
            get
            {
                return 1000;
            }
        }

        public string Material
        {
            get
            {
                return "Skin";
            }
        }
    }
}
