using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] stat = new int[100];

            for (int i = 0; i < 100; i++)
            {

                stat[i] = rand.Next(1, 201);
                //Console.WriteLine(stat[i]);
            }

            //Console.WriteLine("vilket tal ska vi söka efter?");
            //int num = int.Parse(Console.ReadLine());
            //bool foundNum = false;
            
            int[] uddastat = new int[53];

            uddastat[1] = stat[1];

            for (int i = 3; i < 53; i ++)
            {
                uddastat[i] = stat[i + 1];

                Console.WriteLine("index {0} är {1}", i, uddastat[i]);
               
            }
          

            Console.ReadKey();
        }
    }
}
