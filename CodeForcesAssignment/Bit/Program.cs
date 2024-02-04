using System;

namespace Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                string s = Console.ReadLine();
                if (s[1] == '+')
                {
                    x++;
                }
                else
                {
                    x--;
                }
                n--;
            }

            Console.WriteLine(x);
        }
    }
}
