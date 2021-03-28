using System;

namespace ConsoleApp2TEST00._00_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int NB1, NB2, NB3, BN, TO, R = 0;

            Console.Write("");
            NB1 = int.Parse(Console.ReadLine());
            Console.Write("");
            NB2 = int.Parse(Console.ReadLine());
            Console.Write("");
            NB3 = int.Parse(Console.ReadLine());

            while (NB1 + NB2 + NB3 != 0)
            {
                Console.Write("");
                BN = char.Parse(Console.ReadLine());
                Console.Write("");
                TO = int.Parse(Console.ReadLine());
                if (BN == 1)
                {
                    NB1 = NB1 - TO;
                }
                else if (BN == 2)
                {
                    NB2 = NB2 - TO;
                }
                else
                {
                    NB3 = NB3 - TO;
                }

                R++;
            }
            if (R % 2 == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }

            Console.ReadLine();
        }
    }
}
