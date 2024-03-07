using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_IsNullOrEmpty_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //name = null;

            Console.WriteLine($"Your name is {name}");

            /*
            if (name != "")
                Console.WriteLine("0");

            if (!name.Equals(""))
                Console.WriteLine("1");

            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("2");
            */
            
            // This ensure it is null or empty, we don't get an exception
            // Nesting inside IsNullOrEmpty check, it improve the stabability of the program
            // so that exception does not happen
            if (!string.IsNullOrEmpty(name)) // null ""
            {
                if (name.Equals("John"))
                {
                    Console.WriteLine("Correct");
                }
            }

            Console.ReadLine();
        }
    }
}
