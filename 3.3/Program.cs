using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som beräknar summan av de första hundra heltalen.
            int n, m = 0;

            for (int i = 1; i < 101; i++)
            {
                n = i;
                m += n;
            }

            Console.WriteLine("{0}", m);

            Console.ReadKey();
        }
    }
}
