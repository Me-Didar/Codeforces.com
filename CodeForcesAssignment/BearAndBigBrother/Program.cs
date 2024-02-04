using System;

namespace BearAndBigBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            string Persons = Console.ReadLine();
            string[] Weight = Persons.Split(" ");
            int Lomak = int.Parse(Weight[0]);
            int BobWeight = int.Parse(Weight[1]);
            int Year = 0;
            for (; ; )
            {
                Lomak = + Lomak * 3;
                BobWeight = + BobWeight * 2;
                Year++;
                if (Lomak > BobWeight)
                {
                    break;
                }
            }
            Console.WriteLine(Year);
        }
    }
}
