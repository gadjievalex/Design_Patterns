using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleResponsibility
{
    class Handler
    {
        Handler next;
        int id;
        
        public int Limit
        {
            get;
            set;
        }

        public Handler(int id, Handler handler)
        {
            this.id = id;
            Limit = id * 1000;
            next = handler;
        }

        public string HandleRequest(int data)
        {
            if(data <Limit)
            {
                return "Request for " + data + " handled level " + id;
            }
            else if(next != null)
            {
                return next.HandleRequest(data);
            }
            else
            {
                return string.Format(" Request for data " + data + " handled by DEFAULT at level " + id);
            }
        }
    }
}
