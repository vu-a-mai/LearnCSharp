using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Only use var is the variable is obviously what it is going to be
             * Using var too much might hurt the readability of the code
             * You would have to inspect each variable individually...
             */

            //int age = -23;
            // var automatically know it is Int32
            var age = 23;
            Console.WriteLine(age);

            //long bigNumber = -900000000L;
            // var automatically know it is Int64
            var bigNumber = 9000000000000L;
            Console.WriteLine(bigNumber);

            //double negative = -44.2D;
            // var automatically know it is Double
            var negative = -44.2D;
            Console.WriteLine(negative);

            //float precison = 5.000001F;
            // var automatically know it is Single
            var precison = 4.000001F;
            Console.WriteLine(precison);

            //decimal money = 14.99M;
            // var automatically know it is Decimal
            var money = 14.99M;
            Console.WriteLine(money);


            /*
             * It is better to use var for string, rather than number
             */
            // var automatically know it is String
            var name = "Johh";
            Console.WriteLine(name);

            // var automatically know it is Char
            var letter = 'S';
            Console.WriteLine(letter);

            Console.ReadLine();

        }
    }
}
