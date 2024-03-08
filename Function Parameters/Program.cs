using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print function Add directly
            Console.WriteLine(Add(5, 5));

            int num = ReadInt("Enter a number");
            Console.WriteLine(num);

            int angle = ReadInt("Angle");
            Console.WriteLine(angle);

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");
            int result = Add(firstNum, secondNum);

            Console.WriteLine(result);

            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");

            string details = UserDetails(name, age);
            Console.WriteLine(details);

            Console.ReadLine();
        }

        // Function UserDetails
        // string parameter name - take in user name input
        // int parameter age - take in user age input
        // return a string with user name and age
        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}!";
        }
        //function ReadString take in 1 parameter
        // parameter message - a string message
        // return a user input message
        static string ReadString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }
        //function ReadInt take in 1 parameter
        // parameter message - a string message
        // Convert string to Int32 and return it
        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // Function Add take in 2 parameters
        // parameter a - first number
        // parameter b - second number
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
