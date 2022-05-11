using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCredit
{
    public class Experian : CreditAgency
    {
        private int score = 700;

        public override int PullScore()
        {
            return score;
        }
    }
}
