using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Harmonic
    {
        public void HarmonicNumber()
        {
            double sum = 0.0;
            Console.WriteLine("Enter of number for harmonic to find their Sum : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("1/{0} + ",i);
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine("Sum of Series :" + sum);
        }
    }
}
