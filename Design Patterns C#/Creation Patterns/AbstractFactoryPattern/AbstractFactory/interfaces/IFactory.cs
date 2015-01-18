using AbstractFactory.interfaces;
using AbstractFactory.interfaces.products;

namespace AbstractFactory
{
    interface IFactory<Brand>where Brand:IBrand
    {
        IBags CreateBag();
        IShoes CreateShoes();
    }
}
