using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            PrimeFactors primefactors = new PrimeFactors();
            primefactors.Factors();
        }
    }
}
