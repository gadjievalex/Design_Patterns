using AbstractFactory.interfaces;
using AbstractFactory.interfaces.products;
using System;

namespace AbstractFactory
{
    class Client<Brand> where Brand:IBrand,new()
    {
        public void ClientMain()
        {
            IFactory<Brand> factory = new Factory<Brand>();

            IBags bag = factory.CreateBag();

            IShoes shoes = factory.CreateShoes();

            Console.WriteLine(" bag material is - > " + bag.Material);
            Console.WriteLine(" Price is - > " + shoes.Price);
        }
    }
}
