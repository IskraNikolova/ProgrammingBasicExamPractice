namespace Problem5
{
    using System;

    public class Problem5
    {
        public static void Main()
        {
            ulong walls = ulong.Parse(Console.ReadLine());

            int emergencyKits = int.Parse(Console.ReadLine());
            int attacksLength = int.Parse(Console.ReadLine());

            for (int i = 0; i < attacksLength; i++)
            {
                int bit = int.Parse(Console.ReadLine());
                ulong mask = ~((ulong)1 << bit);
                walls = walls & mask;
            }

            for (int i = 0; i < 64; i++)
            {
                int pos = i;
                ulong nRight = walls >> pos;
                ulong bit = nRight & 1;

                int pos2 = i + 1;
                ulong nRight2 = walls >> pos2;
                ulong bit2 = nRight2 & 1;

                if (bit == 0 && bit2 == 1 || 
                    bit == 1 && bit2 == 0 ||
                    bit == 1 && bit2 == 1)
                {
                    continue;
                }
                else
                {
                    if (emergencyKits > 0)
                    {
                        ulong mask = (ulong)1 << pos;
                        walls = walls | mask;
                        emergencyKits--;
                    }

                    int posS = i + 1;
                    ulong nRightS = walls >> posS;
                    ulong bitS = nRightS & 1;

                    int pos2S = i + 2;
                    ulong nRight2S = walls >> pos2S;
                    ulong bit2S = nRight2S & 1;
                    if (bitS != bit2S)
                    {
                        if (emergencyKits > 0)
                        {
                            ulong mask = (ulong)1 << posS;
                            walls = walls | mask;
                            emergencyKits--;
                        }
                    }
                }
            }

            Console.WriteLine(walls);
         
        }
    }
}
