using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class GreatestNumber
    {
        public void LargeNumber()
        {
            // takes 3 numbers from user
            Console.Write("Enter the first number :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number :");
            int number3 = Convert.ToInt32(Console.ReadLine());
            //condition to find Largest Number
            if (number1 > number2 && number1 > number3)
                Console.WriteLine("The 1st Number is the greatest among three" );
            else if (number2 > number1 && number2 > number3)
                Console.WriteLine("The 2nd Number is the greatest among three");
            else
                Console.WriteLine("The 3rd Number is the greatest among three");
            
        }
    }
}
