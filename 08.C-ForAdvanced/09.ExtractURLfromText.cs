using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ExtractURLfromText
    {
            
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputData = input.Split(' ');
            List<string> words = new List<string>();
            for (int i = 0; i < inputData.Length; i++)
			{
			 words.Add(inputData[i]);
			}
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Contains("http://") || words[i].Contains("www."))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }

