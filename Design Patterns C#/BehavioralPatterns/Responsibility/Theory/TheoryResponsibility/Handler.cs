using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryResponsibility
{
    abstract class Handler
    {
        protected Handler succesor;

        public void SetSuccessor(Handler successor)
        {
            this.succesor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
