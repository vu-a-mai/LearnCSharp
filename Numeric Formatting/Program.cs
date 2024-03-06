using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Numeric_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            //Console.WriteLine(string.Format("{0} {1}", value, 1000));
            Console.WriteLine(string.Format("{0}", value));
            // Print value to 0 decimal format
            Console.WriteLine(string.Format("{0:0}", value));
            // Print value to 1 decimal format
            Console.WriteLine(string.Format("{0:0.0}", value));
            // Print value to 2 decimal format
            Console.WriteLine(string.Format("{0:0.00}", value));

            // Using # will trim off any trailing 0
            Console.WriteLine(string.Format("{0:0.#}", value));

            double money = 10D / 3D; // 3.333333333333
            Console.WriteLine(money);
            Console.WriteLine(string.Format("${0:0.00}", money));
            Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}", money));

            // Use the C format to tell the compiler you want to process this as currency base on location of the machine
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            // Use CultureInfo to scale program
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            // Use CreateSpecificCulture to create specific currency
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

            Console.ReadLine();
        }
    }
}
