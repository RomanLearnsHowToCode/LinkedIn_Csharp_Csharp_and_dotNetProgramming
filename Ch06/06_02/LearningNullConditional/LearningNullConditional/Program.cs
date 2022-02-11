using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dealing with NULL
namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = null;

            if(person != null)
            {
                Console.WriteLine(person?.Name);
            } else {
                Console.WriteLine("Person not found");
            }

            Person person2 = new Person() { Name = "Tim" }; //what if this was null
            // Person2 name lenght is 3 as expected
            Console.WriteLine("Person2 name lenght is " + person2?.Name.Length);

            //If it is not declared then it will result in error, Name? will help here
            Person person3= new Person();
            Console.WriteLine("Person 3 name length is" + person3?.Name?.Length);
        }
    }
}