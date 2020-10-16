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
                
                stat[i] = rand.Next(1, 7);
                Console.WriteLine(stat[i]);
            }
            
            

            Console.ReadKey();
        }
    }
}
