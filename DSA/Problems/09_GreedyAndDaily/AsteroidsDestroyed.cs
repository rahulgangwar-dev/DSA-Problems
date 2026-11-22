using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    internal class AsteroidsDestroyedArray
    {
        //int mass = 5;
        //int[] asteroids = [4, 9, 23, 4];

        //bool ans = AsteroidsDestroyedArray.AsteroidsDestroyed(mass, asteroids);
        //Console.WriteLine("Asteroid Destroyed: " + ans);

        //int mass1 = 10;
        //int[] asteroids1 = [3, 9, 19, 5, 21];

        //bool ans1 = AsteroidsDestroyedArray.AsteroidsDestroyed(mass1, asteroids1);
        //Console.WriteLine("Asteroid Destroyed: " + ans1);
        public static bool AsteroidsDestroyed(int mass, int[] asteroids)
        {

            asteroids = AggressiveCows.SortFun(asteroids);

            long currentMass = mass;
            if (asteroids[0] >= currentMass)
            {
                return false;
            }
            currentMass += asteroids[0];

            for (int i = 1; i < asteroids.Length; i++)
            {
                if (asteroids[i] >= currentMass)
                {
                    return false;
                }
                currentMass += asteroids[i];
            }

            return true;
        }

    }
}
