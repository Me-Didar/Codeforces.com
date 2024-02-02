using System;

namespace WaterMelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int MelonWeight = int.Parse(Console.ReadLine());
            if (MelonWeight % 2 == 0 && MelonWeight != 2)
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
