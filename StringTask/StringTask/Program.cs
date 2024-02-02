using System;

namespace StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string TargetWord = Console.ReadLine().ToLower();
            string Output = "";
            string Vowels = "aeiouy";          
            if (TargetWord.Length >= 1 && TargetWord.Length <= 100)
            {
                int LoopCount = 0;
                foreach (char character in TargetWord)
                {
                    if (Vowels.Contains(character))
                    {

                    }
                    else 
                    {
                        if (LoopCount == 0)
                        {
                            Output += "." + character.ToString().Trim();
                        }
                        else 
                        {
                            Output += "."+character.ToString().Trim();
                        }
                    }
                    LoopCount ++;
                }
                Console.WriteLine(Output);
            }
            else 
            {
                Console.WriteLine("Please Check Word!");
            }
          
        }
    }
}
