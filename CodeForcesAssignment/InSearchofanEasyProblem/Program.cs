using System;

namespace InSearchofanEasyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Persons = int.Parse(Console.ReadLine());
            int Result = 0;
            string opinions = Console.ReadLine();
            string _opinions = string.Empty;
            foreach (char opinion in opinions.Trim())
            {
                if (opinion == ' ')
                {

                }
                else
                {
                    _opinions = _opinions + opinion;
                }
            }
            int loop = 1;
            foreach (char opinion in _opinions.Trim())
            {
                string Value = opinion.ToString();
                if (loop <= Persons)
                {
                    if (opinion == '0')
                    {

                        Result += Convert.ToInt32(opinion.ToString());
                    }
                    else
                    {
                        Result += Convert.ToInt32(opinion.ToString());
                    }
                }
                loop++;
            }
            if (Result != 0)
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }


        }
    }
}