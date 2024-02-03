using System;

namespace LuckyNumberNearby
{
    class Program
    {
        static void Main(string[] args)
        {
            long LuckyNumber = long.Parse(Console.ReadLine());
            int Remainder = 0;
            while (LuckyNumber != 0)
            {
                if (LuckyNumber % 10 == 4 || LuckyNumber % 10 == 7)
                {
                    Remainder += 1;
                }
                LuckyNumber /= 10;
                //  Console.WriteLine(n);
            }

            if (Remainder == 4 || Remainder == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
