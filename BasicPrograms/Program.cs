using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Basic Programs");

            //Calling FlipCoin()
            HeadTail headtail = new HeadTail();
            //headtail.FilpCoin();

            //calling FindLeapYear();
            LeapYear leapyear = new LeapYear();
            //leapyear.FindLeapYear();

            //calling PowerCalculaton()
            PowerOfTwo poweroftwo = new PowerOfTwo();
            //poweroftwo.PowerCalculation();

            //calling HarmoniNumber()
            Harmonic harmonic = new Harmonic();
            harmonic.HarmonicNumber();
            
        }
    }
}
