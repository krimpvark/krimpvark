using System;

namespace InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator()
        {

        }

        public decimal InterestReceived(decimal openingBalance, decimal rate, DateTime startDate, DateTime endDate)
        {
            decimal endBalance = openingBalance;
            
            int numberOfDaysInBank = GetDays(startDate, endDate);

            if (0 == numberOfDaysInBank)
                return openingBalance;
            else
                for (int i = 0; i <= numberOfDaysInBank; i++)
                    endBalance += AddInterest(rate, endBalance);

            return endBalance;
        }

        public decimal InterestDaily(decimal openingBalance, decimal rate, DateTime startDate, DateTime endDate)
        {
            decimal endBalance = openingBalance;

            int numberOfDaysInBank = GetDays(startDate, endDate);

            if (0 == numberOfDaysInBank)
                return openingBalance;
            else
            {
                rate /= numberOfDaysInBank;
                
                for (int i = 0; i <= numberOfDaysInBank; i++)
                    endBalance += AddInterest(rate, endBalance);
            }

            return endBalance;
        }

        public decimal InterestExample(decimal openingBalance, decimal rate, DateTime startDate, DateTime endDate)
        {
            decimal endBalance = openingBalance;

            int numberOfDaysInBank = GetDays(startDate, endDate);

            if (0 == numberOfDaysInBank)
                return openingBalance;
            else
            {
                rate /= numberOfDaysInBank;

                for (int i = 0; i <= numberOfDaysInBank; i++)
                    endBalance += AddInterest(rate, endBalance);
            }

            return endBalance;
        }

        private int GetDays(DateTime startDate, DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
                throw new Exception("StartDate cannot be bigger than End Date!");
            else if (startDate.Date == endDate.Date)
                return 0;
            else
                return endDate.Subtract(startDate).Days;
        }

        private decimal AddInterest(decimal interestRate, decimal balance)
        {
            return (balance * interestRate) / 100.0m;
        }
    }
}