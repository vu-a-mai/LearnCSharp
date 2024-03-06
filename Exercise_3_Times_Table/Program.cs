using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Times_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ask the user for a number for the table
             * Write a for loop to print X times table
             */

            Console.Write("Enter a number: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) // 1-10
            {
                //Console.Write(i + ":");
                Console.WriteLine("{0} x {1} = {2}", i, numberInput, i * numberInput);
            }

            Console.ReadLine();
        }
    }
}
