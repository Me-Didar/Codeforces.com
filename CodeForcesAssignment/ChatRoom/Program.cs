using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message, target;
            Message = Console.ReadLine();
            target = "hello"; //------------- To Compare with Input Meassage        
            int MessageCharSize = Message.Length;
            int k = 0;
            int TargetSerial = 0;
            char LastChar = '\0';
            char NextChar = '\0';          
            for (int i = 0; i < MessageCharSize; i++)
            {
                //---
                string Running = Message[i].ToString();
                string _LastChar = LastChar.ToString();
                string _NextChar = NextChar.ToString();
                if (target.Contains(Message[i].ToString())) //-------- Checking Input Char is part of "Hello"
                {
                    if (k == 5)
                    {
                        break;
                    }

                    //if (LastChar != Message[i]) //------- Check for Duplicate Char Compare for (ahhellllloou)
                    //{
                    //---- Message[i]  Means first Char of Message string
                    NextChar = target[TargetSerial];
                    if (Message[i] == NextChar)//----- target[n] Target String char
                    {
                        k++;//--------- Increase index to get next  char of Target
                        LastChar = NextChar;
                        TargetSerial++;                      
                    }
                    else
                    {
                        LastChar = Message[i];
                    }
                    //}
                    //else
                    //{
                    //    LastChar = Message[i];
                    //}

                }
                else
                {
                    LastChar = Message[i];
                }
            }


            if (k == target.Length)
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
