using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class HeadTail
    {
        public void FilpCoin()
        {
            //variables
            double headCount = 0, tailCount = 0;
            Console.WriteLine("Enter how many times Coin to be Flipped :");
            int flip = Convert.ToInt32(Console.ReadLine()); //Read the enterd value
            for (int i = 0; i < flip; i++)//to loop no of times coin to be flipped
            {
                Random random = new Random();
                double num = random.NextDouble();//gives value between 0.1 to 0.99
                if (num > 0.5)
                    headCount++;
                else
                    tailCount++;
            }
            //prints heads and tails count 
            Console.WriteLine("Head Count is : " + headCount);
            Console.WriteLine("Tail Count is : " + tailCount);

            //calculating percentages of heads and tails
            double headPercentage = ((headCount / flip) * 100);
            double tailPercentage = ((tailCount / flip) * 100);

            Console.WriteLine("Head Percentage :" + headPercentage);
            Console.WriteLine("Tail Perventage :" + tailPercentage);


        }
    }
}




