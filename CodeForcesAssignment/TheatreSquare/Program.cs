using System;

namespace TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //------- Ekti  Squre Theater ke  koto stone(squre) diye sajano jabe
            //------------ 6
            //------------ 
            var line = Console.ReadLine().Split(" ");
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            int a = int.Parse(line[2]);

            decimal x = 0;
            decimal y = 0;

            if (m % a == 0) //----------- Check Fraction
            {
                x = m / a; 
            }
            else
            {
                x = m / a + 1;
            }

            if (n % a == 0)
            {
                y = n / a;
            }
            else
            {
                y = n / a + 1;
            }

            var result = x * y;
            Console.WriteLine(result);
        }
    }
}
