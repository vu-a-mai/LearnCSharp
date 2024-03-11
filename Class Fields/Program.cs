using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fields
{
    internal class Program
    {
        class Person
        {
            // make the variable private
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }


            //// Setter
            //public void SetName(string name)
            //{
            //    /*
            //    if (!string.IsNullOrEmpty(name))
            //    {
            //        this.name = name;
            //    }
            //    else
            //    {
            //        this.name = "Invalid name!";
            //    }
            //    */

            //    this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            //}

            //// Getter
            //// Very simple, only return the value
            //public string GetName()
            //{
            //    return name;
            //}

            //// Set Age
            //public void SetAge(int age)
            //{
            //    /*
            //    if (age >= 0 && age <= 150)
            //    {
            //        this.age = age;
            //    }
            //    else
            //    {
            //        this.age = -1;
            //    }
            //    */

            //    // condition ? true : false
            //    this.age = age >= 0 && age <= 150 ? age : -1;
            //}

            //// Get Age
            //public int GetAge()
            //{
            //    return age;
            //}

            // Shorter Getter && Setter
            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            public string GetName() => name;
            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
            public int GetAge() => age;
        }
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);

            Console.WriteLine(person.ReturnDetails());

            //person.name = "Harry";
            //person.age = 30;

            // use setter to gain access to private variable
            person.SetName("Harry");
            person.SetAge(40);
            Console.WriteLine(person.ReturnDetails());

            //Console.WriteLine($"Your name is: {person.GetName()}");
            Console.WriteLine($"Your name is: {person.GetName()} and your age is {person.GetAge()}");

            // Test for invalid value
            person.SetName("");
            person.SetAge(500);
            Console.WriteLine($"Testing for invalid value name {person.GetName()} and age {person.GetAge()}");
            Console.WriteLine($"Your name is: {person.GetName()} and your age is {person.GetAge()}");


            Console.ReadLine();
        }
    }
}
