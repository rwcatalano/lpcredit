using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCredit
{
    public class TransUnion: CreditAgency
    {
        private int score = 720;

        public override int PullScore()
        {
            return score;
        }
    }
}
