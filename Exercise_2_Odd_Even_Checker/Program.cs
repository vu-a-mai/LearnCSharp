using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_Odd_Even_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create and intialise two ints
             * Make a variable to work out the remainder
             * Output remainder to the screen
             * Change the first int variable to another number
                    * and recalculate the remainder
                    * ouput new remainder to the screen
             */

            int firstNumber = 5;
            int secondNumber = 10;
            int remainder1 = firstNumber % secondNumber;
            Console.WriteLine($"The remainder of {firstNumber} % {secondNumber} is:");
            Console.WriteLine(remainder1);

            int remainder2 = secondNumber % firstNumber;
            Console.WriteLine($"The remainder of {secondNumber} % {firstNumber} is:");
            Console.WriteLine(remainder2);

            // Testing different number
            firstNumber = 11;
            secondNumber = 2;

            Console.Write($"Assigned new number to first number: {firstNumber}");
            Console.WriteLine();
            Console.Write($"Assigned new number to second number: {secondNumber}");
            Console.WriteLine();

            int newRemainder = firstNumber % secondNumber;
            Console.WriteLine($"The remainder of {firstNumber} % {secondNumber} is:");
            Console.WriteLine(newRemainder);

            Console.ReadLine();
        }
    }
}
