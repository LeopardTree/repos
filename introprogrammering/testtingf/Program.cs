using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] stat = new int[100];
            
            for (int i = 0 ; i < 100; i++)
            {
                
                stat[i] = rand.Next(1, 201);
                Console.WriteLine(stat[i]);
            }

            Console.WriteLine("vilket tal ska vi söka efter?");
            int num = int.Parse(Console.ReadLine());
            bool foundNum = false;

            for (int i = 0; i < 100; i++)
            {
                if (stat[i] == num)
                {
                    foundNum = true;
                    break;
                }
            }
            if (foundNum)
            {
                Console.WriteLine($"hittade {num}");
            }
            else
            {
                Console.WriteLine($"hittade inte {num}");
            }

          

            Console.ReadKey();
        }
    }
}
