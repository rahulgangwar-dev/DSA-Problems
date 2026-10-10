using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchOnAnswer
{
    internal class CapacityToShipPackagesWithinDDays
    {

        //int[] weights1 = [1, 2, 3, 1, 1];
        //int days1 = 4;
        //int ans1 = CapacityToShipPackagesWithinDDays.Capacity(weights1, days1);
        //Console.WriteLine("Req Weight: " + ans1);
        public static int Capacity(int[] weight, int days)
        {
            int low = weight.Max();
            int high = weight.Sum();

            while (low < high)
            {
                int mid = low + (high- low) / 2;
                int Day = reqDays(weight, mid);
                if (Day <= days)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }

        public static int reqDays(int[] weight, int maxWeight)
        {
            int reqDays = 1;
            int currentLoad = 0;
            for (int j = 0; j < weight.Length; j++)
            {
                if (currentLoad + weight[j] > maxWeight)
                {
                    reqDays++;
                    currentLoad = weight[j];
                }
                else
                {
                    currentLoad += weight[j];
                }
            }
            return reqDays;
        }
        public static int Capacity1(int[] weight, int days)
        {
            int sum = weight.Sum();
            int maxWeight = weight.Max();

            for (int capacity = maxWeight; capacity < sum; capacity++)
            {
                int reqDays = 1;
                int currentLoad = 0;
                for (int j = 0; j < weight.Length; j++)
                {
                    if (currentLoad + weight[j] > maxWeight)
                    {
                        reqDays++;
                        currentLoad = weight[j];
                    }
                    else
                    {
                        currentLoad += weight[j];
                    }
                }
                if (reqDays <= days)
                {
                    return capacity;
                }
            }
            return sum;
        }

    }
}
