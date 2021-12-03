using System;

public class InterestCalculator
{
    public InterestCalculator()
    {

    }

    public decimal Interestreceived(decimal openingBalance, decimal rate, DateTime startDate, DateTime endDate)
    {

        decimal endBalance = openingBalance;
        int numberOfDaysInBank = GetDays(startDate, endDate);

        if (numberOfDaysInBank == 0)
            return openingBalance;
        else
            for (int i = 0; i <= numberOfDaysInBank; i++)
            {
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
        return (balance * interestRate) / 100;
    }
}
