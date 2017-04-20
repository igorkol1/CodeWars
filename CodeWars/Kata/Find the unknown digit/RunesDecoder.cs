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

        public RunesDecoder(string expresionToDecode)
        {
            this.expresionToDecode = expresionToDecode;
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
                return expresionToDecode.IndexOf('+');
            }else if (expresionToDecode.Contains('*'))
            {
                return expresionToDecode.IndexOf('*');
            }else if (expresionToDecode.Contains('-'))
            {
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
            numberB = expresionToDecode.Substring(operatorIndex,equalSignIndex-3);
        }

        public void FillGapsInNumber(string expresion, int number)
        {

        }

        public void FillGapsInNumbers()
        {

        }

    }
}
