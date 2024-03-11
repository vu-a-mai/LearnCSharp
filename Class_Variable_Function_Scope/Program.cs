using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Variable_Function_Scope
{
    internal class Program
    {
        class Person
        {
            // make the variable private
            private string name;
            private int age;
            private string test = "hello";

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                //string test = "hi";
                Console.WriteLine(test);
            }

            // Setter
            public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
            }

            // Getter
            // Very simple, only return the value
            public string GetName()
            {
                return name;
            }

            // Set Age
            public void SetAge(int age)
            {
                // condition ? true : false
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            // Get Age
            public int GetAge()
            {
                return age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }

        }

        static int x = 5;
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);
            Console.WriteLine(person.ReturnDetails());

            x = 20;

            Console.ReadLine();
        }

        static void something(Person person)
        {
            x = 10;
        }
    }
}
