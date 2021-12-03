using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator calc = new InterestCalculator();

            Console.WriteLine($"{calc.Interestreceived(100.0m, 0.1m, DateTime.Now.AddDays(-1.0), DateTime.Now)}");
        }
    }
}
