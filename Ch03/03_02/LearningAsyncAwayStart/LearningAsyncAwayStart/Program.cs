using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

// ASYNC with AWAIT.. 
namespace LearningAsyncAwayStart
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program flow is: write line, run download (which is async with await) meanwhile read console
            Console.WriteLine("downloading file");
            Download();       
            Console.ReadLine();

        }

        static async void Download (){
        
            HttpClient client = new HttpClient();
            //var data = await client.GetStringAsync("http://github.com/RomanLearnsHowToCode");
            var data = await client.GetStringAsync("http://rouxacademy.com");
            Console.WriteLine("Download Complete");
            Console.WriteLine(data);
               
        }
   }

}


        // this is now ASYNC with AWAIT
        /*
        static async void Download()
        {
           await Network.Download();
           Console.WriteLine("Download Complete");
        }
        */

        // Imaginary external network library
        /*
        class Network
        {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
        }
        */