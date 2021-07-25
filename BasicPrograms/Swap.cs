using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Swap
    {
        public void SwapOfNumber()
        {
            Console.WriteLine("Enter Two numbers : ");
            //reads two numbers from console
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers Before Swap : " + number1 +" , " + number2);
            //logic for swap of two numbers
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Numbers Before After : " + number1 + " , " + number2);
        }
    }
}
