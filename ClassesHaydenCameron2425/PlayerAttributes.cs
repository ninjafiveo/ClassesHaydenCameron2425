using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHaydenCameron2425
{
    public class PlayerAttributes
    {
        //properties
        public string Name {  get; set; }
        public string Description {  get; set; }
        public int Strength {  get; set; }

        //Constructor 

        public void teacher(string name, string description, int strength)

        {
            Name = name;
            Description = description;
            Strength = strength;
        }

        // Method
        public void DoSomethingMethod()
        {

            Console.WriteLine("Your character: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Strength: {Strength}");
        }

    }
}
