using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class AlphabetCheck
    {
        readonly char value;
        public AlphabetCheck()
        {
            this.value = char.ToLower(value);
        }

        public void CheckingOfAlphabet()
        {
            if(value =='a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
                Console.WriteLine("Entered Alphabet is an Vowel");
            else
                Console.WriteLine("Entered Alphabet is an Consonant");
        }
    }
}
