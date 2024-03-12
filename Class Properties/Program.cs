using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Properties
{
    internal class Program
    {
        class Person
        {
            // make the variable private
            private string name;
            private int age;

            // auto properties
            // make property declaration more consise when no additional logic is required in the property accessors.
            // the compiler creates a private, anonymous backing field that can only be accessed through the property's
            // get's and set's accessors
            // use capital naming
            public string Name { get; set; }
            public int Age { get; set; }
            

            //public string Name
            //{
            //    /*
            //    get 
            //    { 
            //        return name;
            //    }
                
            //    set
            //    {
            //        // default value
            //        //name = value;
            //        name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
            //    }
            //    */

            //    // or
            //    get => name;
            //    // additional logic
            //    set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
            //}
            //public int Age
            //{
            //    /*
            //    get
            //    {
            //        return age; 
            //    }

            //    set
            //    {
            //        // default value
            //        //age = value;
            //        age = value >= 0 && value <= 150 ? value : -1;
            //    }
            //    */

            //    // or
            //    get => age;
            //    // additional logic
            //    set => age = value >= 0 && value <= 150 ? value : -1;
            //}
            
            /*
            // Shorter class properties functions
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            */

            public Person(string name, int age)
            {
                /*
                this.name = name;
                this.age = age;
                */

                Name = name;
                Age = age;
            }

            /*
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
            */


            public string ReturnDetails()
            {
                //return $"Name: {name}\nAge: {age}";

                // Now use 
                return $"Name: {Name}\nAge: {Age}";
            }

        }

        static void Main(string[] args)
        {
            Person person = new Person("John", 30);

            Console.WriteLine(person.ReturnDetails());

            // This is setting
            person.Name = "Harry";
            person.Age = 20;
            //Console.WriteLine(person.ReturnDetails());

            // This is getting
            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            Console.ReadLine();
        }
    }
}
