using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// List is a basic collection data
namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<string>();

            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");
            customers.Add("Roman");

            Console.WriteLine("There are " + customers.Count + " customers");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);

            }
            Console.WriteLine("Customer on index 1 is " + customers[1]);
        }
    }
}
