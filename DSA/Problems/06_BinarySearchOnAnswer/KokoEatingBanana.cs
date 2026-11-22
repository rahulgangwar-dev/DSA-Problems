using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchOnAnswer
{
    internal class KokoEatingBanana
    {

        //int[] piles = [30, 11, 23, 4, 20];
        //int[] piles = [3, 6, 7, 11];
        //int h = 8;
        //int output1 = KokoEatingBanana.EatingLinear(piles, h);
        //Console.WriteLine("Minimum Linear Bananas: " + output1);
        //int output2 = KokoEatingBanana.EatingBinary(piles, h);
        //Console.WriteLine("Minimum Binary Bananas: " + output2);
        public static int EatingLinear(int[] bananas, int hours)
        {
            int max = bananas.Max();

            for (int k = 1; k <= max; k++)
            {
                int reqTime = RequiredTime(bananas, k);

                if (reqTime <= hours)
                {
                    return k;
                }
            }

            return max;
        }

        public static int EatingBinary(int[] bananas, int hours)
        {
            int min = 1;
            int max = bananas.Max();

            while (min < max)
            {
                int mid = (min + max) / 2;

                int reqTime = RequiredTime(bananas, mid);

                // speed valid
                if (reqTime <= hours)
                {
                    max = mid;
                }

                // speed too slow
                else
                {
                    min = mid + 1;
                }
            }

            return min;
        }

        public static int RequiredTime(int[] piles,int k)
        {
            double hours = 0;
            for(int i = 0; i < piles.Length; i++)
            {
                double d = (double)piles[i] / k;
                hours += Math.Ceiling(d);
            }
            return Convert.ToInt32(hours);
        }

    }
}
