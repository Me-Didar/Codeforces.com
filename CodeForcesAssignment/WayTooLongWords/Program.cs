using System;

namespace WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int Line = int.Parse(Console.ReadLine());
            string[] Words = new string[Line];
            string[] Result = new string[Line];
            for (int i = 0; i < Line; i++)
            {
                Words[i] = Console.ReadLine().ToLower();
                if (Words[i].Length <= 10)
                {
                    Result[i] = Words[i];
                }
                else 
                {
                    //---- String  "firt character"+lenght -2 +"Last Character"
                    //  Output = TargetWord.Substring(0, 1).ToUpper() + TargetWord.Substring(1);
                    int WordLenght = Words[i].Length - 2;
                    string Combination1 = Words[i].Substring(0, 1);                  
                    char Combination2 = Words[i][Words[i].Length - 1];
                    Result[i] = Combination1 + (WordLenght.ToString()) + Combination2;
                }             
            }
            for (int d = 0; d < Line; d++)
            {
                Console.WriteLine(Result[d]);
            }
            }
    }
}
