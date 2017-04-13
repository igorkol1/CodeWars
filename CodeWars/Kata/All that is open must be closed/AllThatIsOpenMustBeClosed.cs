using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.All_that_is_open_must_be_closed
{
    class AllThatIsOpenMustBeClosed
    {
        public static bool IsBalanced(string s, string caps)
        {
            SentenceBalance sentance = new SentenceBalance(s,caps);

            return sentance.IsBalance();
        }

    }

}
