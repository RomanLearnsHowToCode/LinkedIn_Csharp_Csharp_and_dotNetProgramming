using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// System.Threading & System.Threading.Tasks
/*
 we can see that tasks is part of the threading namespace, and tasks actually uses threads at their core
to perform their work asynchronously. Threading a more low-level API to give us direct control over threads,
whereas the task system is a higher-level API that makes it easier for us to write modern and managed
asynchronous code without having to implement our own thread manager or thread pooling, 
 
*RELATIONSHIP BETWEEN TASK AND THREAD:
- TASK is a piece of work that needs to get completed
- THREAD is a worker, that can perform that task

- Creating thread:
*we can limit the amount of threads we can start at once, and use them over and over again
*until the task is done..
*
 */
namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting multiple threads - creating 50 threads
            for (int i = 0; i < 50; i++)
            {
                Thread mythread = new Thread(new ThreadStart(Work));
                mythread.Start();
                // annonymous function in lambda expression
                Task.Run(() =>
                {
                    Console.WriteLine("starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("task complete");
                });
            }

            Console.ReadLine();
        }

        static void Work()
        {
            Console.WriteLine("starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("work complete");
        }
    }
}
