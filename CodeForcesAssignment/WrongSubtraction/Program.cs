using System;

namespace WrongSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, a = 0, r, i;         
            string[] input = Console.ReadLine().Split();
            n = Convert.ToInt32(input[0]);//---------- How many Times Tania want to Loop
            a = Convert.ToInt32(input[1]);//---------- How many Times Tania want to Loop
            //---512→511→510→51→50
            for (i = 1; i <= a; i++)
            {
                r = n % 10;
                if (r == 0)
                {
                    n /= 10;
                }
                else
                {
                    n -= 1;
                }
            }

            Console.WriteLine(n);
        }
    }
}
