using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ask user to enter password, and store
             * Ask user to enter password again, and store
             * Check if they are both contai something
                * If so check if they are the same
                    * If they are, print "Passwords match"
                    * If they are not, print "Passwords do not match"
                * If they are empty, print "Please enter a password."
             */

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string passwordCompare = Console.ReadLine();

            Console.WriteLine(password);
            Console.WriteLine(passwordCompare);

            // If password is not empty
            if (!password.Equals(string.Empty))
            {
                // if password confirmation is not empty
                if (!passwordCompare.Equals(string.Empty))
                {
                    // check if password and passwordCompare length is 6 or more characters
                    if(password.Length >= 6 && passwordCompare.Length >= 6)
                    {
                        // if password and passwordCompare match
                        if (password.Equals(passwordCompare))
                        {
                            Console.WriteLine("Password match");
                        }
                        // if password and passwordCompare does not match
                        else
                        {
                            Console.WriteLine("Password do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            Console.ReadLine();
        }
    }
}
