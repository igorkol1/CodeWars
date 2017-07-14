using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Josephus_Survivor
{
    class JosephusSurvivor
    {

        public static int JosSurvivor(int n, int k)
        {
            List<int> people = new List<int>(CreateArray(n));
            int current = k - 1;

            current = current % people.Count;

            while (people.Count > 1)
            {
               
                people.RemoveAt(current);

                current += k - 1;

                current = current % people.Count; 
            }
            return people[0];
        }

        
        private static int[] CreateArray(int n)
        {
            int[] arr = new int[n];

            return FillArrayWithNatural(arr);
        }

        private static int[] FillArrayWithNatural(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }
        
    }
}
