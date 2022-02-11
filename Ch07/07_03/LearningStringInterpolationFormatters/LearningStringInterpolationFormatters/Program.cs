using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * In this app, we are upputting some floats to the console. What if we wanted to limit the amount of 
 * decimals shown? With formatters that work with string interpolation, we can do that.
 */
namespace LearningStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            var point = new { x = 1.1234, y = 2.1254 };
            Console.WriteLine($"x {point.x} y {point.y}");
            // limit Y to one decimal
            Console.WriteLine($"x {point.x} y {point.y:N1}");
            // this will create 10 characters
            Console.WriteLine($"x {point.x} y {point.y,10:N1}");
        }
    }
}