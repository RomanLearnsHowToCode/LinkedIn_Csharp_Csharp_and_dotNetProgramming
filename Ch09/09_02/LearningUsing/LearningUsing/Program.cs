using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 
/*
 The using statement allows us to more conveniently manage resources. We can specify a block or scope where
 a resource will be used. And once we are out of that scope, the resource will get automatically disposed or
 released correctly, as long as that resource implements the IDisposable interface.
 */

/* SYNTAX - automatically dispose something after we have finished using it..
 using (var client = new HttpClient())
{
    // download something with the client
}
 */

namespace LearningUsing
{
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing our resource");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var resource = new MyResource())
            {
                Console.WriteLine("Using my resource");
            }
            Console.WriteLine("Finished");
        }
    }
}