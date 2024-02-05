using System;

namespace VanyaAndFence
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] PersonsFences = Console.ReadLine().Split(' '); //Combination of Person and Fence       
            int Fence = int.Parse(PersonsFences[1]); //height of the fence
            string[] HeightPersons = Console.ReadLine().Split(' '); //split by space(All Person height)
            int width = 0;
            foreach (var Person in HeightPersons)
            {
                var Friend = int.Parse(Person);
                width += Friend > Fence ? 2 : 1;
            }
            Console.WriteLine(width);
        }
    }
}
