using System;

namespace AntonAndDanik
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalChessRound = int.Parse(Console.ReadLine());
            string ChessResult = Console.ReadLine().ToUpper();
            string Output = "";
            int Anton = 0;
            int Danik = 0;
            foreach (char Result in ChessResult.Trim())
            {
                int Round = 0;
                if (Round <= TotalChessRound)
                {
                    if (Result == 'A')
                    {
                        Anton++;
                    }
                    else
                    {
                        Danik++;
                    }
                }
                else 
                {
                    break;
                }

            }
            if (Anton > Danik)
            {
                Output = "Anton";
            }
            else if (Danik > Anton)
            {
                Output = "Danik";
            }
            else 
            {
                Output = "Friendship";
            }
            Console.WriteLine(Output);
        }
    }
}
