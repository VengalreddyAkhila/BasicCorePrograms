using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to basic core programs");
            Console.WriteLine("Press 1. for FlipCoin ");
            Console.WriteLine("Press 2. for Primefactor");
            Console.WriteLine("Press 3. for Leapyear");
            Console.WriteLine("Press 4. for Powerof2");
            Console.WriteLine("Press 5. for  Swap ");
            Console.WriteLine("Press 6. for EvenOrOdd");
            Console.WriteLine("Press 7. for VowelorConsonant");
            Console.WriteLine("Press 8. for LargestNumber");
            Console.WriteLine("Press 9. for QuotientAndRemainder");
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
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
