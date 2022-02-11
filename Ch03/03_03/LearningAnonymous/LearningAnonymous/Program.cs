using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Anonnymous functions - action keyword
/*
 Let's begin by converting our download function into a callback function. To do that, we will need
to use the action keyword. That allows us to pass and functions as delegates, which are essentially
references to a method that we can pass as a parameter.
 */

/*
 CALLBACK, LAMBDA EXPRESSIONS
 
 */
namespace LearningAsyncAwayStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }

        // callback
        static void Download()
        {
            //Network.Download(OnDownloaded);
            //lambda expression ((message) => 
            Network.Download((message) => Console.WriteLine("Download complete " + message));
        }

        // delegate function
        static void OnDownloaded()
        {
            Console.WriteLine("Download Completed");
        }


    }

    // Imaginary external network library

    class Network
    {
        static public void Download(Action<String> callback)
        //static public void Download(Action callback)
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                //callback();
                callback("completed");
                });
        }
    }
}
