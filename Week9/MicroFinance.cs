using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    internal class MicroFinance : IFinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double maxpercent = 0.1;
            int tax = 4;
            double PaidPercentage = AmountPerMonth * maxpercent;
            double totalLoanPercent = (month * PaidPercentage)+ (month*tax);
            return totalLoanPercent;
        }
        public void CheckUserHistory()
        {
            bool result = true;
            Console.WriteLine("Enter amount of months:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of pay per month");
            double AmountPerMonth = Double.Parse(Console.ReadLine());
            while (result)
            {    
                Console.WriteLine($"The user's total loan is : {CalculateLoanPercent(month, AmountPerMonth)}");
                break;
            }
          
            
        }
    }
}
