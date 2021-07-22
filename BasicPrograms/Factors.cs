using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Factors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter of number for harmonic to find their Sum : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)//for loop to find prime factors
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                    number = number / i;
                }
            }
            if(number > 2)
                Console.WriteLine(number);
        }
    }
}
