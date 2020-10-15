using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som skriver ut alla udda tal mellan 625 och upp till och med 767.
            int n;

            for (int i = 625; i < 768; i += 2)
            {
                n = i;
                Console.WriteLine("{0}", i);



            }
            Console.ReadKey();
        }
    }
}
