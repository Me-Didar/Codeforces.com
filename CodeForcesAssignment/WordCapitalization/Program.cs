using System;

namespace WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string TargetWord = Console.ReadLine();
            string Output = "";
            if (TargetWord.Length <= 1000)
            {
                Output = TargetWord.Substring(0, 1).ToUpper() + TargetWord.Substring(1);
                Console.WriteLine(Output);
            }
            else
            {
                Console.WriteLine("Please Check Word! maximum limit 1000");
            }
        }
    }
}
