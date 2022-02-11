using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Learning finally
/*
 Finally lets us execute a block of code whether an exception was thrown or caught, or if it was not caught,
no matter what, the finally block will get executed at the end. So it's really good to use for opening and
closing resources, such as, maybe a database connection.
 */

namespace LearningFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connected to database");

            try
            {
                throw new Exception("error while accessing database resource");
            }
            catch (Exception)
            {
                Console.WriteLine("exception caught");
            }
            // it will be triggered at the end, this is good to release resources, when we are done with them
            // or in case of exception
            finally
            {
                Console.WriteLine("disconnecting database");
            }
        }
    }
}