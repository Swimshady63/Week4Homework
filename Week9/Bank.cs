using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Week9
{
    internal class Bank: IFinanceOperations
    {   
        
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double maxpercent = 0.05;
            double PaidPercentage = AmountPerMonth*maxpercent;
            double totalLoanPercent = (month * PaidPercentage);
            return totalLoanPercent;
        }
        
        public void CheckUserHistory()
        {
            Console.WriteLine("Enter amount of months:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of pay per month");
            double AmountPerMonth = Double.Parse(Console.ReadLine());

            Random gen = new Random();
            bool result = gen.Next(100) < 50 ? true : false;

            if (result == true)
            {
              Console.WriteLine($"The user's total loan would be :{CalculateLoanPercent(month,AmountPerMonth)}");
            }
            else
            {
                Console.WriteLine("Your request was denied");
            }
        }
    }
}
