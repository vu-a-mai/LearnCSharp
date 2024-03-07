using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Using string.Empty to help code maintainable and readable instead of ""
            if (name != string.Empty) //""
            { 
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty");
            }

            Console.ReadLine();
        }
    }
}
