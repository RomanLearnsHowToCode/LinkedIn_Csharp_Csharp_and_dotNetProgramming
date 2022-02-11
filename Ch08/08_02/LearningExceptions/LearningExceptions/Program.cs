using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Try-Catch statement
namespace LearningExceptions
{
    class Program
    {

        /*
        SYNTAX:
        try {
            //something here might thrown an exception
        } 
        catch (type) {
            // do something based on the type or message    
        }
         */

        // SNIPPET - Right click anywhere, click SNIPPET, INSERT SNIPPET - visual C# - propfull
        class Person {
            private String name;

	        public String Name
	        {
		    get { return name;}
		    set {
                    if (value == null){
                        throw new NullReferenceException("name must have a value");

                    }
                    name = value;
                }
	        }

        }

        static void Main(string[] args)
        {   // Handling exceptions
            try
            {
                var person = new Person();
                person.Name = null;
                //string s = null;
                //var l = s.Length;
                //throw new Exception("custom message");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
