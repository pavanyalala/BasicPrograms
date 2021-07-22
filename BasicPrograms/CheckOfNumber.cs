using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class CheckOfNumber
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter a Number to Check Even or Odd ");
            int number = Convert.ToInt32(Console.ReadLine());
            int check = number % 2;
            if (check == 0)
                Console.WriteLine(number + " is Even Number ");
            else
                Console.WriteLine(number + " is Odd number ");
            
        }
    }
}
