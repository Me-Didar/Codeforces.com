using System;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string Words = Console.ReadLine();
            int UpperCase = 0;
            int LowerCase = 0;
            foreach (char Word in Words.Trim())
            {
                if (char.IsUpper(Word))
                {
                    UpperCase++;
                }
                else
                {
                    LowerCase++;
                }

            }
            if (LowerCase > UpperCase)
            {
                Console.WriteLine(Words.ToLower());
            }
            else if (LowerCase < UpperCase)
            {
                Console.WriteLine(Words.ToUpper());
            }
            else
            {
                Console.WriteLine(Words.ToLower());
            }
          
        }
    }
}
