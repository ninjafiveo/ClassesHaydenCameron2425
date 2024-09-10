using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHaydenCameron2425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PlayerAttributes Ninja = new PlayerAttributes("Ninja", "I am Ninja", 100);
            PlayerAttributes Kodi = new PlayerAttributes("Koding Konquerer", "I am Kodi", 200);
            PlayerAttributes Culp = new PlayerAttributes("Culperate", "I am Culp", 100);


            Console.WriteLine(Ninja.Name);
            Console.WriteLine(Ninja.Description);
            Console.WriteLine(Ninja.Strength);





            Console.ReadLine();
        }
    }
}
