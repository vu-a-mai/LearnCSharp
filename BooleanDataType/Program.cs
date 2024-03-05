using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A boolean can only hold True or False value
            // Declare boolean variable and intialize it
            bool value = true;
            bool isMale = true;
            Console.WriteLine(isMale);

            // assigned boolean variable to new state
            isMale = false;
            Console.WriteLine(isMale);

            Console.ReadLine();
        }
    }
}
