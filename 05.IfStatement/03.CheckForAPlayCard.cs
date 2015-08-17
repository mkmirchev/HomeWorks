using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] validCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            bool isCard = false;
            for (int i = 0; i < validCards.Length; i++)
			{
			 if (input == validCards[i])
	            {
		            isCard=true;
                    break;
            	}
			}
            if (isCard == true)
            {
                Console.WriteLine("Yes"); 
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

