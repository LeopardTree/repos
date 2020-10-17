using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lottorad:");
            Random ran = new Random();
            int[] bingo = new int[7];
            int i = 0;
            for (i = 0; i < 7; i++)
            {
                bingo[i] = ran.Next(1, 36);
                //stat[i] = rand.Next(1, 201);
                Console.WriteLine("rad {0}: {1}", i, bingo[i]);
            }


            Console.ReadKey();
        }
    }
}
