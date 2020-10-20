using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ast4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en metod som avgör om ett tal (skickas in i metoden som parameter) är ett primtal
            //            och returnerar true eller false.
            //bool isPrime(int number) { }
            //            Utöka uppgiften med att låta användaren ange ett godtyckligt heltal som sedan testas
            //            med funktionen.
            //
            //En effektiv men primitiv metod för att avgöra om ett tal n är ett primtal, 
            //är att dividera detta med alla hela tal, från 2 till och med det som är närmast mindre än eller lika med {sqrt}(n). 
            //Om därvid någon divisionsrest blir noll, är talet ej ett primtal och processen kan avbrytas.

            //deklarera variabler
            bool logic = false;
            bool loop = true;
            int userInput;
           
            while (loop) 
            {
                Console.WriteLine("Primtalstest. Skriv in ett heltal:");
                userInput = int.Parse(Console.ReadLine());
                int testvalue = userInput;

                logic = IsPrime(testvalue);

                if (logic)
                {
                    Console.WriteLine("talet är ett primtal");
                }
                else
                {
                    Console.WriteLine("talet är inget primtal");
                }
 
            }
            Console.ReadKey();
        }
        static bool IsPrime(int testvalue)
        {
            int i = 2;
            double n = (Math.Sqrt(testvalue));
            bool prime = true;
            if (testvalue == 0 || testvalue == 1)
            {
                prime = false;   
            }
            else
            {
                while (i <= n)
                {

                    if (testvalue % i == 0)
                    {
                        prime = false;
                        break;
                    }

                    i++;
                }
            }
            if (prime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
