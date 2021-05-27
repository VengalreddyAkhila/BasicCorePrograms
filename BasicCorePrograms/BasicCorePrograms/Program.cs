using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to basic core programs");

            Console.WriteLine("Enter a choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CoinPercentage();
                    break;
                case 2:
                    PrimeFactors primefactors = new PrimeFactors();
                    primefactors.Factors();
                    break;
                case 3:
                    Leapyear leapyear = new Leapyear();
                    leapyear.Leapyr();
                    break;
            }
        }
    }
}
