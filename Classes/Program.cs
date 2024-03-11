using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        /*
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        */

        class Person
        {
            public string name;
            public int age;

            public Person()
            {

            }

            // Overload
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.name = "";
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);

            Person person2 = new Person("Tony");
            Console.WriteLine(person2.name);
            Console.WriteLine(person2.age);

            Person person3 = new Person(30);
            Console.WriteLine(person3.name);
            Console.WriteLine(person3.age);

            Person person4 = new Person("John", 25);
            Console.WriteLine(person4.name);
            Console.WriteLine(person4.age);


            Console.Write("Enter your name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter your age: ");
            int newAge = Convert.ToInt32(Console.ReadLine());

            Person newPerson = new Person(newName, newAge);
            
            if (!string.IsNullOrEmpty(newName))
            {
                Console.WriteLine(newPerson.name);
            }

            if (newPerson.age > -1)
            { 
                Console.WriteLine(newPerson.age);
            }

            Console.ReadLine();
        }
    }
}
