using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Find_the_unknown_digit
{
    class RunesDecoder
    {
        private string expresionToDecode =" ";

        public string numberA;
        public string numberB;
        public string result;

        public string noGapNumberA;
        public string noGapNumberB;
        public string noGapResult;

        public char expresionOperator;

        public int intNumberA;
        public int intNumberB;
        public int intResult;

        public RunesDecoder(string expresionToDecode)
        {
            this.expresionToDecode = expresionToDecode;

            GetExpresionResult();
            GetExpresionNumbers();
        }

        public void GetExpresionResult()
        {
            result = expresionToDecode.Substring(FindEqualSignIndex()+1);
        }

        private int FindEqualSignIndex()
        {
            return expresionToDecode.IndexOf('=');
        }

        private int FindOperatorIndex()
        {
            if (expresionToDecode.Contains('+'))
            {
                expresionOperator = '+';
                return expresionToDecode.IndexOf('+');
            }else if (expresionToDecode.Contains('*'))
            {
                expresionOperator = '*';
                return expresionToDecode.IndexOf('*');
            }else if (expresionToDecode.Contains('-'))
            {
                expresionOperator = '-';
                return expresionToDecode.IndexOf('-');
            }else
            {
                throw new FormatException("Expresions did not contain operator");
            }
        }

        public void GetExpresionNumbers()
        {
            int operatorIndex = FindOperatorIndex();
            int equalSignIndex = FindEqualSignIndex();

            numberA = expresionToDecode.Substring(0, operatorIndex);
            numberB = expresionToDecode.Substring(operatorIndex+1,equalSignIndex-numberA.Length-1);
        }

        public void FillGapsInNumbers(char charToFillGap)
        {
            noGapNumberA = numberA.Replace('?', charToFillGap);
            noGapNumberB = numberB.Replace('?', charToFillGap);
            noGapResult = result.Replace('?', charToFillGap);
        }

        public void PraseNumberToInt()
        {
            intNumberA = Convert.ToInt32(noGapNumberA);
            intNumberB = Convert.ToInt32(noGapNumberB);
            intResult = Convert.ToInt32(noGapResult);
        }

        public bool CheckIfExpresionMakeSense()
        {
            bool status = false;

            switch (expresionOperator)
            {
                case '+':
                    status = intNumberA + intNumberB == intResult;
                    break;
                case '*':
                    status = intNumberA * intNumberB == intResult;
                    break;
                case '-':
                    status = intNumberA - intNumberB == intResult;
                    break;
            }
            return status;
        }

        private bool CheckIfAnyNumberStartWithGap()
        {
            //TODO if lenght>1 them check if first sign is ? (thats should slve the problem)
            return (((numberA[0] == '?') || (numberB[0] == '?')) || (result[0] == '?'))&& (((numberA.Length!=1) || (numberB.Length != 1)) || (result.Length!= 1));
        }

        private int GetStartIndex()
        {
            if (CheckIfAnyNumberStartWithGap())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Decode()
        {
            int startIndex = GetStartIndex();

            int index = -1;

            for(int i = startIndex; i < 10; i++)
            {
                FillGapsInNumbers(i.ToString()[0]);

                PraseNumberToInt();

                if (CheckIfExpresionMakeSense())
                {
                    index = i;
                    break;
                }
            }

            return index;
        } 

    }
}
