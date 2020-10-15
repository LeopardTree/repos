using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ast2._0
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
            else
            {

                if (speed <= 40)
                {
                    Console.WriteLine("Du kör för fort och får" +
                        "böta 2000 SEK");
                }

                else
                {



                    if (speed <= 50)
                    {
                        Console.WriteLine("Du har kört för fort" +
                            "och får böta 3000 SEK");
                    }
                    else 
                    {
                        Console.WriteLine("Du har kört för fort " +
                            "och får böta 5000 SEK!" +
                            "Dessutom blir du av med körkortet.");
                    }
                }

            }
            Console.ReadKey();
        }

                
                //userInput = userInput.ToString("F3");
            
        
    }
}
