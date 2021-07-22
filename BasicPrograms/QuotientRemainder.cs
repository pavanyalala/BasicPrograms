using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class QuotientRemainder
    {
        public void Division()
        {
            Console.WriteLine("Enter dividend and divisor");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            //prints quotient and remainder of number
            int quotient = (dividend / divisor);
            int remainder = (dividend % divisor);
            Console.WriteLine("The Quotient : " + quotient);
            Console.WriteLine("The Remainder : " + remainder);
        }
    }
}
