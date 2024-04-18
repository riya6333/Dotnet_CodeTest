using System;
using System.Collections.Generic;

    class OccurencesOfLetter
    {
        public  int displayInfo(string inputString, char letterToCount)
        {
            int count = 0;
            foreach(char c in inputString)
            {
                if(c == letterToCount)
                {
                    count++ ;
                }
            }
            return count;
        Console.ReadLine();
        }
    }

