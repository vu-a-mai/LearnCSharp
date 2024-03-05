using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 3;

            // 10 / 3 = 3 remainder 1
            // 3 x 3 = 9, 1 left over to get to 10

            Console.WriteLine(firstNumber % secondNumber);

            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 3 = 0
            // 13 % 2 = 1

            Console.WriteLine(1000 % 90);   // 10
            Console.WriteLine(100 % 90);    // 10
            Console.WriteLine(71 % 10);     // 1

            Console.ReadLine();
        }
    }
}
