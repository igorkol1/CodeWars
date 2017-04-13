using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Gap_in_Primes
{
    class GapInPrimes
    {
        public static long[] Gap(int g, long m, long n)
        {
            Primes primes = new Primes();

            long[] gap = null;

            long[] primesNumbers = primes.GetPrimeNumbers(m,n);

            for (int i = 0; i < primesNumbers.Length-1; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(primesNumbers[i]);
                Console.WriteLine(primesNumbers[i + 1]);
                Console.WriteLine(primesNumbers[i + 1] - primesNumbers[i]);
                if (primesNumbers[i]>=m && primesNumbers[i + 1] - primesNumbers[i] == g)
                {
                    gap = new long[2];
                    gap[0] = primesNumbers[i];
                    gap[1] = primesNumbers[i + 1];
                    break;
                }
            }

            return gap;

        }
    }
}
