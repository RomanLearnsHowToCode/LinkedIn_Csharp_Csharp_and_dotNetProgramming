using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Using null coalescing, if we try to set a variable to something that happens to be null,
 * it will instead be set to a default value.
 */


/*
* Let's imagine we were accessing the database and most of the user records have name values,
* but one record does not have a value and so it could come back as null. Instead we could put the 
* default value of empty or not available. An important note is that null coalescing does not work with
* value types because value types cannot be null unless we specify it explicitly
*/


namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We want to use null coalescing to set a default value. We can do that with a double question
             * mark syntax followed by the default value.
             */

            /*
             
             */

            int? s = null; //"hello";
            int s2 = s ?? 2; // default value is 2, is the value null integer? If not then use default = 2

            Console.WriteLine(s2);
        }
    }
}
