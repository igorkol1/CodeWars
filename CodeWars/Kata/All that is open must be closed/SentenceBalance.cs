using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.All_that_is_open_must_be_closed
{
    class SentenceBalance
    {
        private string sentence;
        private string specialsPairs;

        public SentenceBalance(string sentence, string specialsPairs)
        {
            Console.WriteLine(sentence);
            Console.WriteLine(specialsPairs);

            this.sentence = sentence;
            this.specialsPairs = specialsPairs;
        }

        public bool IsBalance()
        {
            return IsAllSpecialSignExistInSentence();

            for(int i = 0; i < specialsPairs.Length; i = i+2)
            {
                int firstSignIndex = sentence.IndexOf(specialsPairs[i]);

            }

        }

        public bool IsAllSpecialSignExistInSentence()
        {
            bool status = true;

            foreach(char sign in specialsPairs)
            {
                if (!sentence.Contains(sign))
                {
                    status = false;
                    break;
                }
            }
            return status;
        }



    }
}
