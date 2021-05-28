using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
   public class PowerOf2
    {
        public void Power()
        { 
               double m, n;
              Console.WriteLine("Enter the Number : ");  
                m = double.Parse(Console.ReadLine());
                Console.WriteLine("Give the Exponent : ");
                n = double.Parse(Console.ReadLine());
               double value = Math.Pow(m, n);
            if (m % 2 == 0)
            {
                Console.WriteLine("Result :", value);
                Console.ReadLine();
            }
            
        }
    }
}
