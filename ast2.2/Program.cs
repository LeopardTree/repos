using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ast2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad kör du i för hastighet?:");
            int speed = int.Parse(Console.ReadLine());

            if (speed <= 30)
            {
                Console.WriteLine("Du kör lagligt!");
            }
            
            if (speed > 30 && speed <= 40)
            {
                    Console.WriteLine("Du kör för fort och får" +
                        "böta 2000 SEK");
            }

      
            if (speed > 40 && speed <= 50)
            {
                Console.WriteLine("Du har kört för fort" +
                    " och får böta 3000 SEK");
            }
            if (speed > 50)
            {
                Console.WriteLine("Du har kört för fort " +
                    "och får böta 5000 SEK!" +
                    " Dessutom blir du av med körkortet.");
            }
                

            
            Console.ReadKey();
        }
    }
}
