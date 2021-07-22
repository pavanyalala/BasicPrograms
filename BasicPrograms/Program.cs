using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Basic Programs");

            //1.Calling FlipCoin()
            HeadTail headtail = new HeadTail();
            headtail.FilpCoin();

            //2.calling FindLeapYear();
            LeapYear leapyear = new LeapYear();
            leapyear.FindLeapYear();

            //3.calling PowerCalculaton()
            PowerOfTwo poweroftwo = new PowerOfTwo();
            poweroftwo.PowerCalculation();

            //4.calling HarmoniNumber()
            Harmonic harmonic = new Harmonic();
            harmonic.HarmonicNumber();

            //5.calling PrimeFactor()
            Factors factors = new Factors();
            factors.PrimeFactor();

            //6.calling Division()
            QuotientRemainder quotientremainder = new QuotientRemainder();
            quotientremainder.Division();

            //7.calling SwapOfNumber()
            Swap swap = new Swap();
            swap.SwapOfNumber();

            //8.calling EvenOdd()
            CheckOfNumber checkofnumber = new CheckOfNumber();
            checkofnumber.EvenOdd();

            //9.calling CheckingOfAlphabet()
            AlphabetCheck alphabetcheck = new AlphabetCheck();
            alphabetcheck.CheckingOfAlphabet();

            //10.calling LargeNumber()
            GreatestNumber greatestnumber = new GreatestNumber();
            greatestnumber.LargeNumber();

        }
    }
}
