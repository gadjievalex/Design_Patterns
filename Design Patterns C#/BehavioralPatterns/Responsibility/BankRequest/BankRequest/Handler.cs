using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRequest
{
    class Handler
    {
        Levels level;
        int id;

        public static Random chois = new Random(11);

        static Levels First
        {
            get
            {
                return ((Levels[])Enum.GetValues(typeof(Levels)))[0];
            }
        }

        public static Dictionary<Levels, Structure> structure = new Dictionary<Levels, Structure>
        {
            {Levels.Manager, new Structure{Limit=9000, Positions=1}},
            {Levels.Supervisor, new Structure{Limit=4000, Positions=3}},
            {Levels.Clerk, new Structure{Limit=1000,Positions=10}}
        };

        public static Dictionary<Levels, List<Handler>> handlersAtLevels = new Dictionary<Levels, List<Handler>>
        {
            {Levels.Manager, new List<Handler>()},
            {Levels.Supervisor, new List<Handler>()},
            {Levels.Clerk, new List<Handler>()}
        };

        public Handler(int id, Levels level)
        {
            this.id = id;
            this.level = level;
        }
        public string HandleRequest(int data)
        {
            if (data < structure[level].Limit)
            {
                return "Request for " + data + " handled by " + level + " id " + id.ToString();
            }
            else if (level > First)
            {
                Levels nextLevel = --level;
                int which = chois.Next(structure[nextLevel].Positions);
                return handlersAtLevels[nextLevel][which].HandleRequest(data);
            }
            else
            {
                Exception chainException = new ChainException();
                chainException.Data.Add("Limit", data);
                throw chainException;
            }
        }
    }
}
