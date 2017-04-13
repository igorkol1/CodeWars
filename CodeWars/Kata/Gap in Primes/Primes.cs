using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Gap_in_Primes
{
    class Primes
    {
        bool[] isPrimeNumbers;

        private void InitAndFillIsPrimeNumbersArray(long maxNumber)
        {
            isPrimeNumbers = new bool[maxNumber];
            
            for(int i = 2; i < maxNumber; i++)
            {
                isPrimeNumbers[i] = true;
            }
        }

        public void Find(long maxNumber)
        {
            InitAndFillIsPrimeNumbersArray(maxNumber);
            for (int i = 0; i < maxNumber; i++)
            {
                if (isPrimeNumbers[i])
                {
                    for(int j = i + 1; j < maxNumber; j++)
                    {
                        if(j % i == 0)
                        {
                            isPrimeNumbers[j] = false;
                        }
                    }

                }
            }
        }

        public void PrintPrimes(long maxNumber)
        {
            for(int i = 2; i < maxNumber; i++)
            {
                if (isPrimeNumbers[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

        public long[] GetPrimeNumbers(long maxNumber)
        {
            Find(maxNumber);
            List<long> tempPrimeList = new List<long>();
            for(int i = 2; i < maxNumber; i++)
            {
                if (isPrimeNumbers[i])
                {
                    tempPrimeList.Add(i);
                }
            }
            return tempPrimeList.ToArray();
        }

        public long[] GetPrimeNumbers(long minNumber, long maxNumber)
        {
            List<long> tempPrimeList = new List<long>();

            for(long i = minNumber; i <= maxNumber; i++)
            {
                if (IsPrime(i))
                {
                    tempPrimeList.Add(i);
                }
            }
            return tempPrimeList.ToArray();
        }

        public bool IsPrime(long number)
        {
            bool status = true;
            int root = (int)Math.Sqrt(number);
            if (number % 2 == 0 || number % 3 == 0)
            {
                status = false;
            }
            else
            {
                for(int i = 5; i <= root; i += 6)
                {
                    if (number % i == 0)
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                {
                    for(int i = 7; i <= root; i += 6)
                    {
                        if (number % i == 0)
                        {
                            status = false;
                            break;
                        }
                    }
                }
            }
            return status;
        }



    }
}
