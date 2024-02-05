using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int HouseDistance, Steps = 0;
            int[] Positions = { 5, 4, 3, 2, 1 };
            HouseDistance = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
              //  int test= HouseDistance / Positions[i];
                Steps += HouseDistance / Positions[i];
              //  int test2 = HouseDistance % Positions[i];
                HouseDistance = HouseDistance % Positions[i];
            }

            Console.WriteLine(Steps);
        }
    }
}
