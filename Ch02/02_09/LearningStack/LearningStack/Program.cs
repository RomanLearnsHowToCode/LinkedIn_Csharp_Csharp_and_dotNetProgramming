using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stack is Last IN - First OUT collection
/*Think of it like a pancake stack, as you make the pancakes you place them on a plate
and stack them on top of each other. When the pancakes get served we take them off the top and so the
first one that was made is also the last to be eaten.
*/

//the stack collection is similar to a list collection but with a different order and access methods.

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("last pancake made");

            /*
            foreach (var pancake in pancakes)
            {
                Console.WriteLine(pancake);
            }
            */

            // pop will give us the first item (the last added), pop will also remove the last item from stack
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Peek());
            

        }
    }
}
