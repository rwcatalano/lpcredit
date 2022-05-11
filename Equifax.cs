using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCredit
{
    public class Equifax : CreditAgency
    {
        private int score = 650;

        public override int PullScore()
        {
            return score;
        }
    }
}
