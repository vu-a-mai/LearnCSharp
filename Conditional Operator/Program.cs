using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            if (age >= 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // condition ? true : false
            /*
             * First step is to get the condition
             * If it is true, then return true condition
             * Else return the the false condition
             */

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            // Save variable by printing out directly
            Console.WriteLine(age >= 0 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
