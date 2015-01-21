using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    class Client<Brand>where Brand:IBrand, new()
    {
        public void ClientMan()
        {
            IBuilder<Brand> factory = new Builder<Brand>();
            DateTime date = DateTime.Now;
            Console.WriteLine(" I want buy bag ");
            IBag bag=factory.CreateBag();
            Console.WriteLine(" I got my bag with toock " + DateTime.Now.Subtract(date).TotalSeconds * 5 + " day ");
            Console.WriteLine(" with propeties " + bag.Properties);
        }
    }
}
