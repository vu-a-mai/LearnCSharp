using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Storaging_User_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercise 1: Storing User Data
             * Define a variable to hold name
             * Define a variable to hold phone number
             * Define a variable to hold age
             * Print variables line-by-line to the screen
             * Extra: define variables using the var keyword
             */

            string firstName = "John";
            string phoneNumber = "0123456789";
            int age = 30;

            Console.WriteLine(firstName);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);

            Console.ReadLine();

            var lastName = "Smith";
            var phoneNum = "9876543210";
            int newAge = 25;

            Console.WriteLine(lastName);
            Console.WriteLine(phoneNum);
            Console.WriteLine(newAge);

            Console.ReadLine();
        }
    }
}
