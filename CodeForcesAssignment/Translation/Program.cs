using System;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            char[] Translation = word2.ToCharArray();
            Array.Reverse(Translation);
            string reversedT = new string(Translation);

            if (word1 == reversedT)
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
