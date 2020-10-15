using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] stat = new int[7];
            //slumpa hundra tärningskast
            for (int i = 0; i < 100; i++)
            {
                int roll = rand.Next(1, 7);
                stat[roll] = stat[roll] + 1;
                Console.Write("{0}, ", roll);
            }
            //skriv ut statistik
            for (int i = 0; i <7; i++)
            {
                Console.WriteLine("{0}: {1}", i, stat[i]);
            }
            Console.ReadKey();
        }
    }
}
