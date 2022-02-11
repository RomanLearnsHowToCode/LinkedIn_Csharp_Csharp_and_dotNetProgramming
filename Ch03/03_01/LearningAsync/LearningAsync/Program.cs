using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// 
/*
 asynchronous programming is like deciding to build a house, but instead of doing it all yourself, 
you decide to hire a contractor to do the foundation. Another contractor to do the frame. Another for plumbing,
et cetera. So that they all try to do as much work at the same time, whenever possible. While they are working,
you are also free to do other things, such as project manage, for example, therefore, overall you are able to 
get the job done in maybe just a few months instead of years.
 */

/*
 Asynchronous programming is great when working with tasks that take time such as
reading files from the disc, working with databases, or communicating over the network.
That's why you see modern web frameworks all use asynchronous programming.
 */

// This application needs to download a file and still stay responsive, for this we are using threads
namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine(); // while we are downloading we can type -> ASYNC app
        }

        // TASK -> ASYNC operation, does not return value
        static void Download()
        {   // Annonymous function two round braces without name, and delegate 
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });

        }
    }
}