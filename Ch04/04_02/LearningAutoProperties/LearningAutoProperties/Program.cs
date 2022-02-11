using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Auto implemented properties are a more compact form of the manually implemented properties
/*
One advantage I can think of is that if you have a field with lots of code depending on it, and then you realize
you need some functionality to execute with setting or getting the value, then you will have to rebuild any
code that is in a separate assembly, that is trying to look for that field, if you want to switch it to a
property. In other words, it will cause breaking changes in your app. So it's better to use it from the get-go,
even if you don't need that functionality initially.  
 */
namespace LearningProperties
{
    class Player
    {
        public bool IsAlive
        {
            //get { return health > 0; }
            get { return Health > 0; }
        }

        //public int Health { get; } = 100; -> This won't work
        //public int Health { get; set; } = 100;
        public int Health { get; private set; } = 100;

        /*
        int health = 100;

        // we can publicaly retrieve health (which is private property)
        public int Health
        {
            get { return health; }
        }
        */

        public void Hit()
        {
            Random r = new Random();
            //health -= r.Next(5, 50);
            Health -= r.Next(5, 50);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
