using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            IComponent component = new Component();
            Client client = new Client();

            ComponentCreated(client, component);

            Console.ReadKey();
        }

        private static void ComponentCreated(Client client, IComponent component)
        {
            ShowClient(client, component);  
        }

        private static void ShowClient(Client client, IComponent component)
        {
            client.Display("1. Появляется кто-то ", component);
            client.Display("2. выбрал костюм из шкафа ", new DecoratorA(component));
            client.Display("3. выбрал другой костм", new DecoratorB(component));
            client.Display("4. экспериментирует", new DecoratorA(new DecoratorB(component)));

            DecoratorB bDecorator = new DecoratorB(new Component());

            client.Display("5. экспериментирует снова", new DecoratorA(bDecorator));
            Console.WriteLine("\t\t\t видит " + bDecorator.addedState + bDecorator.AddBehaviour());
        }
    }
}
