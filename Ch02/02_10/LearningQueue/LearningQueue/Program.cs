using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A queue is a first in, first out collection, so, in a sense, it's the opposite of a stack.
 * A good analogy for a queue is in a lineup. The first person to line up to get a coffee is also
 * the first to get served, while the last person in the lineup is the last to get served. 
 */

// Queue is very similar to stack, but the logic is reversed (retrival order)
namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            // queue has got custom methods how to add entry - Enqueue
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);


            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            // dequeue will take first item and take it out
            /*
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            */
        }
    }
}
