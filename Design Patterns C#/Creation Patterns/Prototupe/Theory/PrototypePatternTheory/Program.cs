using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager manager = new PrototypeManager();

            Prototype c2;
            Prototype c3;

            c2 = manager.prototypes["Australia"].Clone();
            PrototypeClient.Report("Shallow clining Australia\n================", manager.prototypes["Australia"], c2);

            c2.Capital="Sydney";
            PrototypeClient.Report("Alerted clones shllow state prototype unaffected", manager.prototypes["Australia"], c2);

            c2.Language.Data = "Chinese";
            PrototypeClient.Report("Alerting clone deep state prototype affected", manager.prototypes["Australia"], c2);

            c3 = manager.prototypes["Germany"].DeepCopy();
            PrototypeClient.Report("Deep clining Germany\n==================", manager.prototypes["Germany"], c3);

            c3.Capital = "Munidh";
            PrototypeClient.Report("Alerted clones shllow state prototype unaffected", manager.prototypes["Germany"], c3);

            c3.Language.Data = "Turkish";
            PrototypeClient.Report("Alerting clone deep state prototype affected", manager.prototypes["Germany"], c3);

            Console.ReadLine();
        }
    }
}
