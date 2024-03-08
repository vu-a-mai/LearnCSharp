using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 10;
            string name = "John";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);
            */

            string name = "John";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, ref newName))
            {
                Console.WriteLine($"Your new name is {newName}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }

            Console.ReadLine();
        }

        static void Assign(ref int num, ref string name)
        {
            name = "Tony";
            num = 20;
        }

        static bool ChangeName(ref string name, ref string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
        }
    }
}
