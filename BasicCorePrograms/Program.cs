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
                case 4:
                    PowerOf2 powerof2 = new PowerOf2();
                    powerof2.Power();
                    break;
                case 5:
                    Swap swap = new Swap();
                    swap.SwapNumber();
                    break;
                case 6:
                    EvenOrOdd evenorodd = new EvenOrOdd();
                    evenorodd.EvenOdd();
                    break;
    
                case 7:
                    VowelOrConsonant vowelorconsonant = new VowelOrConsonant();
                    vowelorconsonant.VowelConst();
                    break;
                case 8:
                    LargestNum largestnum = new LargestNum();
                    largestnum.LargestNumber();
                    break;
                case 9:
                    QuotientRem quotientrem = new QuotientRem();
                    quotientrem.QuotientRemainder();
                    break;
            }
        }
    }
}
