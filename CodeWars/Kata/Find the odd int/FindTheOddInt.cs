using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kata.Find_the_odd_int
{
    class FindTheOddInt
    {
        private static Dictionary<int, int> numbersCount;

        public static int find_it(int[] seq)
        {
            numbersCount = new Dictionary<int, int>();
            for (int i = 0; i < seq.Count(); i++)
            {
                if (numbersCount.ContainsKey(seq[i])){
                    numbersCount[seq[i]] += 1; 
                }else
                {
                    numbersCount.Add(seq[i], 1);
                }
            }
            return ReturnNumberWithOddAppears(seq);
        }

        private static int ReturnNumberWithOddAppears(int[] seq)
        {
            int index = 0;
            for(int i = 0; i < seq.Count(); i++)
            {
                if(numbersCount[seq[i]] % 2 != 0)
                {
                    index = seq[i];
                    break;
                }
            }
            return index;
        }
    }
}
