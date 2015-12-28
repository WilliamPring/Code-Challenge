//https://www.hackerrank.com/challenges/game-of-thrones
//Help him figure out whether any anagram of the string can be a palindrome or not.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            char c = '0';
            bool status = false;
            int countOfTime = 0;
            string mystring = Console.ReadLine();
            int totalLength = mystring.Length;
            mystring = SortString(mystring);
            for (int i = 0; i < totalLength; )
            {
                string singleInfo = mystring[i].ToString();
                int count = mystring.Length - mystring.Replace(singleInfo, "").Length;
                totalLength = totalLength - count;
                mystring = mystring.Remove(0, count); 
                if (count % 2 != 0)
                {
                    if (countOfTime>= 2)
                    {
                        break;
                    }
                    countOfTime++;
                }
               

            }
            if ((countOfTime == 1) || (countOfTime ==0))
            {
Console.WriteLine("YES");
            }
            else
            {
Console.WriteLine("NO");
            }
        
        
    }
    
    static string SortString(string stringToSort)
        {
            char[] ConvertString = stringToSort.ToArray();
            Array.Sort(ConvertString);
            return new string(ConvertString);
        }
}