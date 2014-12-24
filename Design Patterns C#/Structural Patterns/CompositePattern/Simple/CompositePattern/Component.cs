using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Component<T>:IComponent<T>
    {
        public Component(T name)
        {
            Name = name;
        }
        public void Add(IComponent<T> c)
        {
            throw new NotImplementedException();
        }

        public IComponent<T> Remove(T s)
        {
            throw new NotImplementedException();
        }

        public string Display(int depth)
        {
            throw new NotImplementedException();
        }

        public IComponent<T> Find(T s)
        {
            throw new NotImplementedException();
        }

        public T Name
        {
            get;
            set;
        }
    }
}
