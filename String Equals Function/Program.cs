using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Equals_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //if (name != "")
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            /*
             * Different comparision
             */
            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            // This compare concern about the value rather than the memory
            if (message.Equals(newCompare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            // This compare string and object memory
            if (message == newCompare)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}
