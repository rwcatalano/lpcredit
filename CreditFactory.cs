using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCredit
{
    public class CreditFactory
    {
        public CreditAgency Create(int creditAgencyType)
        {
            switch (creditAgencyType)
            {
                case 0:
                    return new Equifax();
                case 1:
                    return new Experian();
                case 2:
                    return new TransUnion();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
