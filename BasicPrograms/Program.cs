using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to  Basic Programs");
            Console.WriteLine("Choose An option to execute program \n1.FlipCoin \n2.LeapYear \n3.PowerOf2 \n4.HarmonicNumber \n5.PrimeFactorisation \n6. QuotientRemainder \n7. SwapOfNumber \n8. EvenOdd \n9. CheckingOfAlphabet \n10. LargeNumber ");
            Console.WriteLine("Select Option from 1 to 10 ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    HeadTail headtail = new HeadTail();
                    headtail.FilpCoin();
                    break;

                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.FindLeapYear();
                    break;

                case 3:
                    PowerOfTwo poweroftwo = new PowerOfTwo();
                    poweroftwo.PowerCalculation();
                    break;

                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.HarmonicNumber();
                    break;

                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactor();
                    break;

                case 6:
                    QuotientRemainder quotientremainder = new QuotientRemainder();
                    quotientremainder.Division();
                    break;

                case 7:
                    Swap swap = new Swap();
                    swap.SwapOfNumber();
                    break;

                case 8:
                    CheckOfNumber checkofnumber = new CheckOfNumber();
                    checkofnumber.EvenOdd();
                    break;

                case 9:
                    AlphabetCheck alphabetcheck = new AlphabetCheck();
                    alphabetcheck.CheckingOfAlphabet();
                    break;

                case 10:
                    GreatestNumber greatestnumber = new GreatestNumber();
                    greatestnumber.LargeNumber();
                    break;

            }
            
            

           

        }
    }
}
