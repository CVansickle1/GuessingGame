using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    internal class Method
    {
        public static bool Participate(string ans)
        {
            while (true)
            {
                bool participate;
                if (ans != null && (ans == "y" || ans == "yes"))
                {
                    return participate = true;
                    
                }
                else if (ans != null && (ans == "n" || ans == "no"))
                {
                   return participate = false;
                    
                }
                else
                {
                    Console.WriteLine("Only y or n Allowed");
                    ans = Console.ReadLine();
                }
            }
        }

    }
}
