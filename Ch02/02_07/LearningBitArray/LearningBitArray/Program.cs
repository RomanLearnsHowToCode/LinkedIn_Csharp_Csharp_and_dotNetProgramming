using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A BitArray collection allows us to count and display bits, as well as perform bitwise operations.
namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring and initialising boolean array preload, which contain 3 values, T,F,T
            bool[] preload = new bool[3] { true, false, true };

            // BitArray enemyGrid is new BitArray which contain boolean values from preload
            BitArray enemyGrid = new BitArray(preload);

            // MANUAL INSERTION
            //enemyGrid[0] = false;
            //enemyGrid[1] = true;
            //enemyGrid.Set(2, false);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }

        }
    }
}
