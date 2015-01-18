﻿using AbstractFactory.interfaces;

namespace AbstractFactory.Brands
{
    class Poochy:IBrand
    {
        public int Price
        {
            get
            {
                return new Gucci().Price / 3;
            }
        }

        public string Material
        {
            get
            {
                return "Plastic";
            }
        }
    }
}
