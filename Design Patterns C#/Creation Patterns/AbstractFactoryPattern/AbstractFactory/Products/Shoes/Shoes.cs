using AbstractFactory.interfaces;
using AbstractFactory.interfaces.products;

namespace AbstractFactory.Products.Shoes
{
    class Shoes<Brand>:IShoes where Brand:IBrand,new()
    {
        private Brand myBrand;

        public Shoes()
        {
            myBrand = new Brand();
        }

        public int Price
        {
            get
            {
                return myBrand.Price;
            }
        }
    }
}
