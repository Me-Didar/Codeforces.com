using System;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lenght = int.Parse(Console.ReadLine());
            string Words = Console.ReadLine().ToUpper();         
            string Alphabet = string.Empty;
            foreach (char Word in Words.Trim())
            {
                if (Alphabet.Contains(Word.ToString()))
                {

                }
                else 
                {
                    Alphabet = Alphabet + Word.ToString();
                }
            }
            if (Alphabet.Length == 26)
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
