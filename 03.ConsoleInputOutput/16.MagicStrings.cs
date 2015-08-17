using System;

    class MagicStrings
    {
        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            char[][] data = new char[2][];
            data[0] = new char[] {'k', 'n', 'p', 's' };
            data[1] = new char[] { '1', '4', '5', '3' };
            bool isMagic = false;
            int diff1 = 0;
            int diff2 = 0;
            for (int s = 0; s < 4; s++)
            {
                for (int si = 0; si < 4; si++)
                {
                    for (int f = 0; f < 4; f++)
                    {
                        for (int fo = 0; fo < 4; fo++)
                        {
                            for (int th = 0; th < 4; th++)
                            {
                                for (int tw = 0; tw < 4; tw++)
                                {
                                    for (int on = 0; on < 4; on++)
                                    {
                                        for (int z = 0; z < 4; z++)
                                        {
                                            diff1 = Convert.ToInt16(data[1][s]) + Convert.ToInt16(data[1][si]) + Convert.ToInt16(data[1][f]) + Convert.ToInt16(data[1][fo]);
                                            diff2 = Convert.ToInt16(data[1][th]) + Convert.ToInt16(data[1][tw]) + Convert.ToInt16(data[1][on]) + Convert.ToInt16(data[1][z]);
                                            if (diff==Math.Abs(diff1-diff2))
                                            {
                                                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}",data[0][s],data[0][si],data[0][f],data[0][fo],data[0][th],data[0][tw],data[0][on],data[0][z]);
                                                isMagic = true;
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (isMagic==false)
            {
                Console.WriteLine("No");
            }

        }
    }

