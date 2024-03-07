using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            //angles?

            // initialize array
            //int[] numbers = new int[3]; // instantiate x position

            //numbers[0] = 5;
            //numbers[1] = 10;
            //numbers[2] = 15;

            /*
            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine());
            */

            //Console.WriteLine($"{num1} {num2} {num3} ");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]} ");

            // initialize array
            int[] numbers = new int[3]; // instantiate x position

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // For loop
            // can specified the length it go through
            // 0 to 900, can choose from (500-600)
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            
            Console.WriteLine();


            // For each loop
            // Will go through every position
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            Console.Write("Enter angle 1: ");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter angle 2: ");
            int angle2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter angle 3: ");
            int angle3 = Convert.ToInt32(Console.ReadLine());

            int angleSum = angle1 + angle2 + angle3;

            Console.Write(angleSum == 180 ? "Valid" : "Invalid");

            Console.WriteLine();

            Console.WriteLine("Using Array");
            // Using Array
            const int angleCount = 3;   // constant angle count
            int[] angles = new int[angleCount]; // instantiate array with angle count

            // Use for loop to stored angle in the array
            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleTotal = 0;

            foreach (int angle in angles)
            {
                angleTotal += angle;    // 0 + 60 + 60 + 60
            }

            Console.WriteLine(angleTotal);
            Console.Write(angleTotal == 180 ? "Valid" : "Invalid"); // Check if the angleTotal is 180. If it is then print "Valid", otherwise print "Invalid"

            Console.WriteLine();

            // Improvement to the above code
            Console.WriteLine("Printing from improvement code");
            const int newAngleCount = 3;
            int newAngleSum = 0;

            for (int i = 0; i < newAngleCount ; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                newAngleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(newAngleSum == 180 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
