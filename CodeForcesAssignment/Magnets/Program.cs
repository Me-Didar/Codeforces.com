using System;

namespace Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnets = int.Parse(Console.ReadLine());
            string[] magnet = new string[magnets];
            int i = 0;
            int magnetGroup = 1;
            while (i<= magnets-1)
            {
                magnet[i] = Console.ReadLine();
                
                i++;
            }
            for (int j = 0; j < magnet.Length; j++)
            {
                if (j >0 && (magnet[j].ToString()!= magnet[j-1].ToString()))
                {
                    magnetGroup++;
                }
               

            }
            Console.WriteLine(magnetGroup.ToString());

        }
    }
}
