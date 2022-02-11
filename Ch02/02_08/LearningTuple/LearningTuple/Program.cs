using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TUPLE - it is not a collection, but it allows us to create a list of items with the same type
/* when would be a good time to actually use a tuple? Let's imagine we were getting an object from a 
server or database. Instead of creating a dot net class, it might be simpler to just use a tuple in some cases.
Another reason might be to return multiple items from a function, since traditionally, we can only return one
item.*/
namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // two ways how to declare tuple, in second case tuple will determine data type by itself, and it is cleaner
            //Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);

            var myTuple = Tuple.Create(1, "hello", true);

            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item3);
        }
    }
}
