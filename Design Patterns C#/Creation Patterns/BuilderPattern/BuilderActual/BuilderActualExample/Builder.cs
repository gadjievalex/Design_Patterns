using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    class Builder<Brand>:IBuilder<Brand>where Brand:IBrand, new()
    {
        Brand myBrand;

        public Builder()
        {
            myBrand = new Brand();
        }

        public IBag CreateBag()
        {
            return myBrand.CreateBag();
        }
    }
}
