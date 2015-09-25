using System;
using System.Collections.Generic;

    class RemoveNames
    {
        static void Main()
        {   
            // first input list
            string fInput = Console.ReadLine();
            string[] fNames = fInput.Split(' ');
            List<string> firstInput = new List<string>();
            for (int i = 0; i < fNames.Length; i++)
            {
                firstInput.Add(fNames[i]);
            }
            // second input list
            string sInput = Console.ReadLine();
            string[] sNames = sInput.Split(' ');
            List<string> secondInput = new List<string>();
            for (int i = 0; i < sNames.Length; i++)
            {
                secondInput.Add(sNames[i]);
            }
            for (int i = 0; i < (firstInput.Count/secondInput.Count) + 1; i++)
            {
               for (int index = 0; index < secondInput.Count; index++)
            {
                if (firstInput.Contains(secondInput[index]))
                {
                    firstInput.Remove(secondInput[index]);
                }
            } 
            }
            // printing first list of names with removed names from the second list of names
            foreach (var name in firstInput)
            {
                Console.Write(name + " ");
            }
            
        }
    }

