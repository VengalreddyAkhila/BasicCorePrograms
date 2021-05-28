using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class Harmonic
    {
        public void HarmonicNumber()
        {
            int i, n;
            double s = 0.0;
            Console.WriteLine("Calculate the harmonic series :");
            Console.WriteLine(" Number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s = s + 1 / (float)i;
            }
        }

            
    }
}
