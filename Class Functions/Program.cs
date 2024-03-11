using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Functions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Function inside the class
            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }
        static void Main(string[] args)
        {

            Person person = new Person("John", 25);

            //Console.WriteLine(ReturnDetails(person.name, person.age));
            
            // Pass in the class
            Console.WriteLine(ReturnDetails(person));

            // Calling from class
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }

        // Pass in Person
        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }        
        /*
        static string ReturnDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
        }
        */
    }
}
