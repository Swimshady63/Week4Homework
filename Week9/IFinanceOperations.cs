using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public interface IFinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth);
        public void CheckUserHistory();

    }
}
