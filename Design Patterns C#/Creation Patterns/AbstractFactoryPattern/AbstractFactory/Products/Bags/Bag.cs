using AbstractFactory.interfaces;

namespace AbstractFactory
{
    class Bag<Brand>:IBags where Brand:IBrand, new()
    {
        private Brand myBrand;

        public Bag()
        {
            myBrand = new Brand();
        }

        public string Material
        {
            get { return myBrand.Material; }
        }
    }
}
