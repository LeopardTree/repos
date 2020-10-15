using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utgå från övning 3:3 och låt användaren ange mellan vilka två tal programmet ska räkna summman

            

            Console.WriteLine("Ange ett tal:");
            int numberX = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett tal till:");
            int numberY = int.Parse(Console.ReadLine());


            int n, m = 0;

            if (numberX < numberY)
            
                for (int i = numberX; i < numberY + 1; i++)
                {
                    n = i;
                    m += n;
                }
            
            else
                for (int i = numberY; i < numberX + 1; i++)
                {
                    n = i;
                    m += n;
                }


            Console.WriteLine("{0}", m);

            Console.ReadKey();
        }
    }
}
