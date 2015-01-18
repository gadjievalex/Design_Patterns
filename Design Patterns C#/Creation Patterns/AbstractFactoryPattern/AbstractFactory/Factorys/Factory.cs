using AbstractFactory.interfaces;
using AbstractFactory.interfaces.products;
using AbstractFactory.Products.Shoes;

namespace AbstractFactory
{
    class Factory<Brand>:IFactory<Brand>where Brand:IBrand, new()
    {

        public IBags CreateBag()
        {
            return new Bag<Brand>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();
        }
    }
}
