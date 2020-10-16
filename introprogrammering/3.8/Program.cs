using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100 slumptärningskast");
            Random rand = new Random(5); // Skapa en slumpmojäng
            int i = 0;
            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;

            for (i = 0; i < 100; i++)
            {
                int dice = rand.Next(1, 7);
                //Console.Write("{0},", dice);
                switch (dice)
                {
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                    case 3:
                        threes++;
                        break;
                    case 4:
                        fours++;
                        break;
                    case 5:
                        fives++;
                        break;
                    case 6:
                        sixes++;
                        break;
                }
            }

            Console.WriteLine("Ettor: {0}", ones);
            Console.WriteLine("tvåor: {0}", twos);
            Console.WriteLine("treor: {0}", threes);
            Console.WriteLine("fyror: {0}", fours);
            Console.WriteLine("femmor: {0}", fives);
            Console.WriteLine("sexor: {0}", sixes);
            Console.ReadKey();
        }
    }
}
