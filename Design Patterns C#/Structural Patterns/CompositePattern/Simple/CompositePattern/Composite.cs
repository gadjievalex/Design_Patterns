using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite<T>:IComponent<T>
    {
        List<IComponent<T>>lIst;

        public T Name
        {
            get;
            set;
        }

        public Composite(T name)
        {
            Name = name;
            lIst = new List<IComponent<T>>();
        }

        public void Add(IComponent<T>c)
        {
            lIst.Add(c);
        }

        IComponent<T> holder = null;

        public IComponent<T>Remove(T s)
        {
            holder = this;

            IComponent<T> p = holder.Find(s);

            if(holder != null)
            {
                (holder as Composite<T>).lIst.Remove(p);

                return holder;
            }
            else
            {
                return this;
            }    
        }

        public IComponent<T> Find(T s)
        {
            holder = this;

            if (Name.Equals(s))
            {
                return this;
            }
            IComponent <T> found = null;

            foreach(IComponent<T> c in lIst)
            {
                found = c.Find(s);

                if(found != null)
                {
                    break;
                }
            }
            return found;
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new String('-', depth));

            s.Append("Set " + Name + " length :" + lIst.Count + "\n");

            foreach(IComponent<T> component in lIst)
            {
                s.Append(component.Display(depth + 2));
            }

            return s.ToString();
        }
    }
}
