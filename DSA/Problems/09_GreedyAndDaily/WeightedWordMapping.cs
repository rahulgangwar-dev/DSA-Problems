using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    public class WeightedWordMapping
    {
        //: words = ["abcd", "def", "xyz"], weights = [5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2]
        //Output: "rij"
        public string MapWordWeights(string[] words, int[] weights)
        {
            Dictionary<char, int> key = new Dictionary<char, int>();
            Dictionary<int, char> val = new Dictionary<int, char>();
            string s = "";
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                key[c] = weights[i];
                val[25 - i] = c;
                c++;
            }
            foreach (var w in words)
            {
                int value = 0;
                for (int i = 0; i < w.Length; i++)
                {
                    value += key[w[i]];
                }
                s += val[value % 26];
            }
            return s;
        }

        public string MapWordWeights1(string[] words, int[] weights)
        {
            Dictionary<char, int> key = new Dictionary<char, int>();
            Dictionary<int, char> val = new Dictionary<int, char>();
            string s = "";
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                key[c] = weights[i];
                val[25 - i] = c;
                c++;
            }
            foreach (var w in words)
            {
                int value = 0;
                for (int i = 0; i < w.Length; i++)
                {
                    value += key[w[i]];
                }
                s += val[value % 26];
            }
            return s;
        }
    }

}
