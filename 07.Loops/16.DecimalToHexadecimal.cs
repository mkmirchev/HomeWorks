using System;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            long inpCopy = input;            
            long counter = 0;
            int pos = 1;
            while (inpCopy >= 16)
            {
                counter = inpCopy / 16;
                inpCopy = counter;
                pos++;
            }
            //Console.WriteLine(pos);
            string revHex = "";
            for (int i = pos-1; i >= 0; i--)
            {
               string a = Convert.ToString(input % 16);
                
                switch (a)
                {
                    case "0":
                        revHex += "0";
                        break;
                    case "1":
                        revHex += "1";
                        break;
                    case "2":
                        revHex += "2";
                        break;
                    case "3":
                        revHex += "3";
                        break;
                    case "4":
                        revHex += "4";
                        break;
                    case "5":
                        revHex += "5";
                        break;
                    case "6":
                        revHex += "6";
                        break;
                    case "7":
                        revHex += "7";
                        break;
                    case "8":
                        revHex += "8";
                        break;
                    case "9":
                        revHex += "9";
                        break;
                    case "10":
                        revHex += "A";
                        break;
                    case "11":
                        revHex += "B";
                        break;
                    case "12":
                        revHex += "C";
                        break;
                    case "13":
                        revHex += "D";
                        break;
                    case "14":
                        revHex += "E";
                        break;
                    case "15":
                        revHex += "F";
                        break;                  
                }
                input /= 16;
                
            }
            //Console.WriteLine(revHex);
            for (int i = revHex.Length-1; i >= 0 ; i--)
            {
                Console.Write(revHex[i]);
            }
            Console.WriteLine();
        }
    }

