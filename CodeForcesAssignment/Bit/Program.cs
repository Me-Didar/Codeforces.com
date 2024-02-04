using System;

namespace Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int operations, Result = 0;
            operations = int.Parse(Console.ReadLine());

            while (operations > 0)
            {
                string s = Console.ReadLine();
                if (s[1] == '+')
                {
                    Result++;
                }
                else
                {
                    Result--;
                }
                operations--;
            }

            Console.WriteLine(Result);
        }
    }
}
