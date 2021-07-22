using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        public void PowerCalculation()
        {
            Console.WriteLine("Enter the Number to Print 2 table : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            while (start <= number)
            {
                Console.WriteLine("2" + " ^ " + start + " = " + Math.Pow(2, start));
                start++;
            }
        }
    }
}
