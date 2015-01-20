﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    interface IBuilder<Brand>where Brand:IBrand
    {
        IBag CreateBag();
    }
}
