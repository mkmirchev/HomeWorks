using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LongestWordInText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ', '.', ',', '!', '?');
            int longestWordIndex = 0;            
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i].Length > words[longestWordIndex].Length)
                {
                    longestWordIndex = i;                   
                }
            }
            Console.WriteLine(words[longestWordIndex]);
        }
    }

