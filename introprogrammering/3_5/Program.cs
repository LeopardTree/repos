using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programmet ska fråga användaren efter ett godtyckligt tal och sedan informerar
            //användaren om det är ett primtal eller inte.
            //En effektiv men primitiv metod för att avgöra om ett tal n är ett primtal, 
            //är att dividera detta med alla hela tal, från 2 till och med det som är närmast mindre än eller lika med {sqrt}(n). 
            //Om därvid någon divisionsrest blir noll, är talet ej ett primtal och processen kan avbrytas.

            Console.WriteLine("Primtalstest. Skriv in ett heltal:");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            double n = (Math.Sqrt(userInput));
            bool isprime = true;
            while (i <= n)
            {
                
                if( userInput % i == 0)
                {
                    
                    isprime = false;
                    break;

                }

                i++;
            }
            if (isprime)
            {
                Console.WriteLine("talet är ett primtal");
            }
            else
            {
                Console.WriteLine("talet är inget primtal");
            }
            Console.ReadKey();
        }
    }
}
