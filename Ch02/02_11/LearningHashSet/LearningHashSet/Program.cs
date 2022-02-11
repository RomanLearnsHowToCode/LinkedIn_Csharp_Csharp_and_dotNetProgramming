using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A hash set is an optimized set collection. It helps eliminate duplicate strings or elements in an array.
//Using the hash set is a good idea when you want to maintain an optimized collection.
namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            var myHash = new HashSet<String>();

            // Eventhough we have got twice "hello", HashSet will optimise and remove duplicates
           myHash.Add("hello");
           myHash.Add("hello");
           myHash.Add("hello");

            String[] s = new String[] { "hello" };

            // the count will be 1, because of optimisation and duplicates removal
            Console.WriteLine(myHash.Count);
            // Overlaps allow us to compare another array or set to see if it contains the same items that the hash set contains. 
            Console.WriteLine(myHash.Overlaps(s)); // overlaps is a boolean which will tell if there has been duplicates in code
        }
    }
}
