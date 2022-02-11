using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exception filtering allows us to set a condition on our catch statement.
namespace LearningExceptionFilters
{
    class PersonException : Exception
    {
        public PersonException(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new PersonException("Kim");
                throw new PersonException("Bob");

            }
            // Original catch statement
            /*
            catch (PersonException ex) 
            {
                if (ex.Name == "Kim")
                    Console.WriteLine("its from Kim, lets ignore it");

                if (ex.Name == "Bob")
                    Console.WriteLine("its from Tim, make sure we log this");
            }
            */
            catch (PersonException ex) when (ex.Name == "Kim")
            {
                Console.WriteLine("its from Kim, lets ignore it");
            }
            catch (PersonException ex) when (ex.Name == "Bob")
            {
                Console.WriteLine("its from Bob, lets ignore it");
            }
        }
    }
}
