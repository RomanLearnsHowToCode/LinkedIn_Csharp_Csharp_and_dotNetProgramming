using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if we did this in the loop we would provide a lot of unnecessary work for the garbage collector. 
namespace LearningStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };

            Console.WriteLine("x " + point.x + " y " + point.y);

            Console.WriteLine("x {0} y {1}", point.x, point.y);
            // string interpolation
            Console.WriteLine($"x {point.x} y {point.y}");
        }
    }
}
