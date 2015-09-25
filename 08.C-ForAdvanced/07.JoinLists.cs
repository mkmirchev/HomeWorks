using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class JoinLists
    {
        static void Main()
        {
            // first input list
            string fInput = Console.ReadLine();
            string[] fNumbs = fInput.Split(' ');
            List<int> firstInput = new List<int>();
            for (int i = 0; i < fNumbs.Length; i++)
            {
                firstInput.Add(Convert.ToInt32(fNumbs[i]));
            }
            // second input list
            string sInput = Console.ReadLine();
            string[] sNumbs = sInput.Split(' ');
            List<int> secondInput = new List<int>();
            for (int i = 0; i < sNumbs.Length; i++)
            {
                secondInput.Add(Convert.ToInt32(sNumbs[i]));
            }          
                   for (int index = 0; index < secondInput.Count; index++)
            {
                if (firstInput.Contains(secondInput[index]) == false)
                {
                    firstInput.Add(secondInput[index]);
                }
            }
            firstInput.Sort();
            for (int i = 1; i < firstInput.Count; i++)
            {
                if (firstInput[i-1] == firstInput[i])
                {
                    firstInput.Remove(firstInput[i - 1]);
                }
            }              
            foreach (var number in firstInput)
            {
                Console.Write(number + " ");
            }
        }
    }

