using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ToString_Function_Override
{
    class Person
    {
        // make the variable private
        private string name;
        private int age;


        public string Name
        {
            get => name;
            // additional logic
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
        }
        public int Age
        {
            get => age;
            // additional logic
            set => age = value >= 0 && value <= 150 ? value : -1;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ReturnDetails()
        {
            return $"Name: {Name}\tAge: {Age}";
        }

        public override string ToString()
        {
            //return ReturnDetails();

            return $"Name: {Name}\tAge: {Age}";
        }

        public override bool Equals(object obj)
        {
            // is use for checking
            if (obj is Person)
            {
                // as use for converting
                // cast object as a person
                // convert obj into a person
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }

            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Harry", 25);

            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            Person test = new Person("Harry", 25);

            Console.WriteLine(test);


            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not the same");
            }

            Console.ReadLine();
        }
    }
}
