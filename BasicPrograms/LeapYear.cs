using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        public void FindLeapYear()
        {
            Console.WriteLine("Enter the Year Wheather to check Leap or Not :");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 100 == 0))
                Console.WriteLine(" Entered Year is a Leap year ");
            else
                Console.WriteLine(" Entered Year is not a Lead Year ");



        }
    }
}
