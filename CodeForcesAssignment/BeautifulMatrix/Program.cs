using System;

namespace BeautifulMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldBreak = false;
            int Result = 0;
            for (int i = 1; i <= 5; i++)
            {
                string Matrix = Console.ReadLine();
                string[] s1values = Matrix.Split(' ');

                for (int j = 1; j <= 5; j++)
                {
                    int x = int.Parse(s1values[j - 1]);  
                    if (x == 1)
                    {
                        Result = Math.Abs(i - 3) + Math.Abs(j - 3);                     
                        shouldBreak = true;
                    }
                }
                if (shouldBreak)
                {
                    // Break from the outer loop
                    break;
                }
            }    
         Console.WriteLine(Result.ToString());
        }
    }
}
