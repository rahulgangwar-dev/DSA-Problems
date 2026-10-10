using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.PrefixSuffixKadane
{
    internal class BestTimetoBuyandSellStock
    {
        //int[] arr = { 1, 2, 3, 4, 5 };

        //int[] ans = ProductofArrayExceptSelf.ProductofArray(arr);
        //Console.Write("Product of Array: ");
        //for (int i = 0; i<ans.Length; i++)
        //{
        //    Console.Write(" "+ans[i]);
        //}

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyIndex = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                buyIndex = Math.Min(buyIndex, prices[i]);
                int profit = prices[i] - buyIndex;
                maxProfit = Math.Max(profit, maxProfit);
            }
            return maxProfit;
        }

        public static int[] BestTimeNew(int[] arr)
        {
            int minPrice = arr[0];
            int profit = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                minPrice = Math.Min(minPrice, arr[i]);
                int p = arr[i] - minPrice;
                profit = Math.Max(p, profit);
            }

            return new int[] { minPrice, profit };
        }

        //Kadane’s Algorithm
        //int[] arr = { 2, 4, 1 };

        ////int[] arr = { 7, 1, 5, 3, 6, 4 };
        //int[] arr = { 2, 4, 1 };

        //int[] ans = BestTimetoBuyandSellStock.BestTime(arr);
        //Console.WriteLine("Purchase at: " + ans[0]);
        //Console.WriteLine("Sell at: " + ans[1]);
        public static int[] BestTime(int[] arr)
        {
            int minPrice = arr[0];
            int maxProfit = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                minPrice = Math.Min(minPrice, arr[i]);
                int profit = arr[i] - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }

            return new int[] { maxProfit };
        }
        
    }
}

