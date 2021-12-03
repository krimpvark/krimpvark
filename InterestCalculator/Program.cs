using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator calc = new InterestCalculator();

            Console.WriteLine($"{calc.InterestReceived(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now)}");
            Console.WriteLine($"{calc.InterestDaily(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now)}");
        }
    }
}
