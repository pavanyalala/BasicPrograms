using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Basic Programs");
            HeadTail headtail = new HeadTail();
            headtail.FilpCoin();
            LeapYear leapyear = new LeapYear();
           // leapyear.FindLeapYear();
        }
    }
}
