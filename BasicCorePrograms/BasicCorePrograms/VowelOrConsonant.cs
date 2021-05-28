using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void VowelConst()
        {
            Console.WriteLine("Enter any Alphabet: ");
            char Check = Convert.ToChar(Console.ReadLine());

           Check = char.ToLower(Check);

            Console.WriteLine("Enter any Alphabet: ");
            
            if (Check  == 'a' || Check == 'e' || Check  == 'i' || Check  == 'o' || Check == 'u')
            {
                Console.WriteLine(Check+ " is Vowel");
            }
            else 
            {
                Console.WriteLine(Check+ " is Consonant");
            }
        }
    }
}
