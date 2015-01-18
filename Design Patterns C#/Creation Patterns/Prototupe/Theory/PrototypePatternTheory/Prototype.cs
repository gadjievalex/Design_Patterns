using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTheory
{
    [Serializable]
    public class Prototype:IPrototype<Prototype>
    {
        public string Country
        {
            get;
            set;
        }

        public string Capital
        {
            get;
            set;
        }

        public DeeperData Language
        {
            get;
            set;
        }

        public Prototype(string country, string capital, string language)
        {
            Country = country;
            Capital = capital;
            Language = new DeeperData(language);
        }

        public override string ToString()
        {
            return Country + "\t\t" + Capital + "\t\t->" + Language;
        }
    }
}
