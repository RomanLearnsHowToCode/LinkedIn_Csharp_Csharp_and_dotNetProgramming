using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A property is a member that provides a mechanism to read, write, and compute the value of a private field.
 * Properties seem to act like public variables, but they are more like functions in a way because they
 * contain special methods called accessors, which are the getters and setters of the property. 
 */ 

/*
* The nice thing about properties, is we have more control over access. Since I did not define a setter,
* if we tried to set isAlive, we will get an error since this is not possible. Unlike a public variable which we
* can set and possibly break our application. 
 */
namespace LearningProperties
{
    class Player
    {
        // Let's conver isAlive into property
        //public bool isAlive = true;

        public bool IsAlive {// naming convention for properties = capital I
            get {return health > 0; }
        } 

        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        // We don't need this function anymore, since the logic is in property function
        /*
        public void CheckDeath()
        {
            if (health <= 0)
                isAlive = false;
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            //setter will throw error
            //player.IsAlive = false;

            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                //player.CheckDeath(); // we don't need this check anymore
                //Console.WriteLine("Is player alive: " + player.isAlive);
                //We need to update the console log and log IsAlive..
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
