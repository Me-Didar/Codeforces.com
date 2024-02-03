using System;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string Team = Console.ReadLine();
            int Team1 = 0;
            int Team2 = 0;
            int SituationLevel = 0;
            if (Team.Length <= 100)
            {
                foreach (char Player in Team.Trim())
                {
                    if (Player == '0' || Player == '1')
                    {
                        if (Player == '0')
                        {
                            Team2 = 0;
                            if (SituationLevel > 0 && Team2 == 0 && Team1 == 0)
                            {
                                Team1++;
                                SituationLevel = 1;
                            }
                            else
                            {
                                Team1++;
                                SituationLevel += 1;
                                if (SituationLevel >= 7)
                                {
                                    break;
                                }
                            }


                        }
                        else
                        {
                            Team1 = 0;

                            if (SituationLevel > 0 && Team1 == 0 && Team2 == 0)
                            {
                                Team2++;
                                SituationLevel = 1;
                            }
                            else
                            {
                                Team2++;
                                SituationLevel += 1;
                                if (SituationLevel >= 7)
                                {
                                    break;
                                }
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Plese Insert Valid Data1!");
                        return;
                    }
                }
                if (SituationLevel >= 7)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("Plese Insert Valid Data2!");
            }

        }
    }
}
