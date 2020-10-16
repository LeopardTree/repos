using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace losn.array.ovn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mult = new int[10, 10];
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mult[i - 1, j - 1] = 1 * j;
                    Console.Write("{0}", i * j);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("****{j}:ans tabell****");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("      {0} x {1} = {2}", j, i, mult[i - 1, j - 1]);
                }
            }
            
            
            Console.ReadKey();

        }
    }
}
