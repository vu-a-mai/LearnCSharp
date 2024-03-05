using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing from DataTypes Project.");

            // Integer
            Console.WriteLine("Printing Integer Data Type");
            // declare int 32 variable
            // Hover over the "30" to see the representation
            int age = 30;
            Console.WriteLine("Printing age variable:");
            Console.WriteLine(age);
            Console.WriteLine("IntMinValue: " + int.MinValue);
            Console.WriteLine("IntMaxValue: " + int.MaxValue);

            Console.WriteLine("Alternative way to print using $ interpolation");
            // Alternative way of printing using '$' symbol before the string to interpolate '{}'
            Console.WriteLine($"IntMinValue: { int.MinValue }");
            Console.WriteLine($"IntMaxValue: { int.MaxValue }");

            // add L at the end of the interger to represent it as a long int
            // declare int 64 variable
            Console.WriteLine("Printing Long Int Data Type");
            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            // Negative number
            long negativeBigNumber = -900000000L;
            Console.WriteLine(negativeBigNumber);

            Console.WriteLine("LongIntMinValue: " + int.MinValue);
            Console.WriteLine("LongIntMaxValue: " + int.MaxValue);

            Console.WriteLine("Alternative way to print using $ interpolation");
            // Alternative way of printing using '$' symbol before the string to interpolate '{}'
            Console.WriteLine($"LongIntMinValue: {int.MinValue}");
            Console.WriteLine($"LongIntMaxValue: {int.MaxValue}");

            // Double
            Console.WriteLine("Printing Double Data Type");
            // add D at the end of the interger to represent it as a double
            double negativeNumber = 100.2D;
            Console.WriteLine(negativeNumber);
            Console.WriteLine($"DoubleMinValue: {double.MinValue}");
            Console.WriteLine($"DoubleMaxValue: {double.MaxValue}");

            // Float
            Console.WriteLine("Printing Float Data Type");
            // add F at the end of the interger to represent it as a double
            double precisionNumber = 30.00001F;
            Console.WriteLine(precisionNumber);
            Console.WriteLine($"FloatMinValue: {float.MinValue}");
            Console.WriteLine($"FloatMaxValue: {float.MaxValue}");

            // Decimal
            Console.WriteLine("Printing Float Data Type");
            // add M at the end of the interger to represent it as a decimal
            decimal money = 9.99M;
            Console.WriteLine(money);
            Console.WriteLine($"DecimalMinValue: {decimal.MinValue}");
            Console.WriteLine($"DecimalMaxValue: {decimal.MaxValue}");


            // Multiple way to declare variable
            int a = 10;
            int b = 20;
            int c = 30;

            // declare variable in one line
            int d = 10, e = 20, f = 30;

            // or
            int x = 10,
                y = 20,
                z = 30;

            // assigned/change variable
            a = 100;
            d = 40;
            z = 10;

            Console.ReadLine();
        }
    }
}
