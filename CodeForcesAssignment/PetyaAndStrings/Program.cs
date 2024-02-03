using System;

namespace PetyaAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //In a lexicographical (or lexicographic) comparison, each character is compared based on its ASCII or Unicode value.

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            // Perform lexicographical comparison        
            int result = string.Compare(str1.ToLower(), str2.ToLower());        
            if (result < 0)
            {
                Console.WriteLine("-1");
            }
            else if (result > 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
