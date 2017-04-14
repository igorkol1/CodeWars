using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.String_Integer_Greater_than
{
    class StringIntegerGreaterComparison
    {
        
        public static bool StringIntGreaterThan(string a, string b)
        {
            bool status = false;
            if (IsStringsIntHaveDiffrentSign(a, b))
            {
                status = IsFirstStringIsNegative(a, b);
            }
            else
            {
                status = CompareStringWithTheSameSign(a, b);


                if (IfBothStringAreNegative(a, b) && (a!=b))
                {
                    status = !status;
                }


            }
            return status;

        }

        private static bool CompareStringWithTheSameSign(string a, string b)
        {
            bool status;

            if (IsStringsHaveDiffrentLenght(a, b))
            {
                status = IsFirstStringLonger(a, b);
            }
            else
            {
                status = CompareStringIntWithTheSameLenght(a, b);
            }

            return status;
        }

        private static bool IsStringsIntHaveDiffrentSign(string a, string b)
        {
            return a.Contains('-') ^ b.Contains('-');
        }

        private static bool IfBothStringAreNegative(string a, string b)
        {
            return a.Contains('-') && b.Contains('-');
        }

        private static bool IsFirstStringIsNegative(string a,string b)
        {
            bool status = false;
            if(a.Contains('-') && !b.Contains('-'))
            {
                return false;
            }
            else if(!a.Contains('-') && b.Contains('-'))
            {
                return true;
            }
            return status;
        }

        private static bool IsStringsHaveDiffrentLenght(string a, string b)
        {
            return a.Length != b.Length;
        }

        private static bool IsFirstStringLonger(string a,string b)
        {
            return a.Length > b.Length;
        }

        private static bool CompareStringIntWithTheSameLenght(string a,string b)
        {
            bool status = false;

            a = a.Replace('-', '0');
            b = b.Replace('-', '0');

            for (int i = 0; i< a.Length; i++)
            {
                int numberFromA = Convert.ToInt16(Convert.ToString(a[i]));
                int numberFromB = Convert.ToInt16(Convert.ToString(b[i]));

                if (numberFromA > numberFromB)
                {
                    status = true;
                    break;
                }else if(numberFromA < numberFromB)
                {
                    break;
                }
            }
            return status;
        }
    }
}
