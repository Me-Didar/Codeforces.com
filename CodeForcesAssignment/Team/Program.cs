using System;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int Round = int.Parse(Console.ReadLine());
            int Aggred = 0;
            for (int i = 0; i < Round; i++)
            {
                string Problems = Console.ReadLine();
                string[] Problem = Problems.Split(" ");
                int Decision =  int.Parse(Problem[0]) + int.Parse(Problem[1])+ int.Parse(Problem[2]);
                if (Decision >= 2)
                {
                    Aggred++;
                }
            }
            Console.WriteLine(Aggred.ToString());
        }
    }
}
