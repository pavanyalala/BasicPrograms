using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class AlphabetCheck
    {
        public void CheckingOfAlphabet()
        {
            Console.WriteLine("Enter a Alphabet to check : ");
            char alphabet = Convert.ToChar(Console.ReadLine());
            //checks lower case Alphabets
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                Console.WriteLine(alphabet + " is a Vowel");
            //checks upper case Alphabets
            else if (alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
                Console.WriteLine(alphabet + " is a Vowel");
            else
                Console.WriteLine(alphabet + " is a Consonant");
        }
    }
}
