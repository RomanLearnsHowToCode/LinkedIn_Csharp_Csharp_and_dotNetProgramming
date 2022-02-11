using System;
using System.Collections; // we need to include ArrayList, it is not generic..
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An ArrayList is very similar to a List. In fact, it's deprecated, and replaced by the List collection we looked at earlier.
//Boxing is the process of converting your string, or date, or whatever into a regular C# object.
namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("some string");
            String s = (String)list[0];
            Console.WriteLine(list[0]); // accessing boxed object

            int i = 123;
            object o = i;
            Console.WriteLine(o);
            
        }
    }
}
