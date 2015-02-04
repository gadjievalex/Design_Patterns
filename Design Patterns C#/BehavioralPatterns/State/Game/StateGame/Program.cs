using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Context contexn = new Context();
            contexn.State = new RestingState();
            char command=' ';
            
            Console.WriteLine(" Welcome to state game ");
            Console.WriteLine(" You standing and relaxing ");

            while(char.ToLower(command)!='e')
            {
                Console.WriteLine("what you wont to do now");
                Console.WriteLine("Move Attck Stop Run Panic CalmDown Exit the Game:==>");
                string choise;

                do
                    choise = Console.ReadLine();

                while (choise == null);
                command=choise[0];
                contexn.Request(command);
            }
            Console.ReadLine();
        }
    }
}
