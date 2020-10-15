using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0 | i % 7 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
