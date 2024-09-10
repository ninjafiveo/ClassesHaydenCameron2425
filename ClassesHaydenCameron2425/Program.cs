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
            
            PlayerAttributes Sekol = new PlayerAttributes();
            

            Sekol.Name = "Ninja";
            Sekol.Description = "I am Mr. Sekol";
            Sekol.Strength = 1000;
            Console.WriteLine(Sekol.Name);
            Console.WriteLine(Sekol.Description);
            Console.WriteLine(Sekol.Strength);





            Console.ReadLine();
        }
    }
}
