using System;

namespace TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //------- Ekti  Squre Theater ke  koto stone(squre) diye sajano jabe
            var line = Console.ReadLine().Split(" ");
            var m = long.Parse(line[0]);
            var n = long.Parse(line[1]);
            var a = long.Parse(line[2]);

            var x = 0L;
            var y = 0L;

            if (m % a == 0)
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
