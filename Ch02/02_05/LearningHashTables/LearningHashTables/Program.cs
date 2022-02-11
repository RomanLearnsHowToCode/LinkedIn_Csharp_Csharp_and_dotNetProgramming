using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hash table was replaced by dictionary
namespace LearningHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            // identical process of adding entry into hashtable
            table.Add("title", "MyWebsite");

            //casting
            var s = (String)table["title"];
            Console.WriteLine(s);
        }
    }
}
