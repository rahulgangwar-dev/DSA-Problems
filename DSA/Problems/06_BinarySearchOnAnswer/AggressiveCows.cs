using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchOnAnswer
{
    internal class AggressiveCows
    {

        //stalls = [1, 2, 4, 8, 9]
        //cows = 3
        //output =  1   4   8
         
        
        public static int Cows(int[] stalls,int cows)
        {
            stalls = SortFun(stalls);


            int maxGap = stalls[stalls.Length - 1] - stalls[0];
            int ans = 0;

            for (int gap = 1; gap <= maxGap; gap++)
            {
                if (ValidCows(stalls, gap, cows))
                {
                    ans = gap;
                }
                else
                {
                    break;
                }
            }
            return ans;
        }

         //[1, 2, 4, 8, 9]
        public static bool ValidCows(int[] stalls, int gap,int cows)
        {
            int need = 0;
            int currIndex = 0;
            int totalCows = 1;
            for(int i = 1; i <= stalls.Length-1; i++)
            {
                need = stalls[i] - stalls[currIndex];
                if (need >= gap)
                {
                    currIndex = i;
                    totalCows++;
                }
                if (cows <= totalCows)
                {
                    return true;
                }
            }


            return false;
        }

        public static int[] SortFun(int[] stalls)
        {
            for (int i = 0; i < stalls.Length - 1; i++)
            {
                for (int j = i + 1; j < stalls.Length; j++)
                {
                    if (stalls[i] > stalls[j])
                    {
                        int temp = stalls[i];
                        stalls[i] = stalls[j];
                        stalls[j] = temp;
                    }
                }
            }
            return stalls;
        }


        
    }
}
