using System;

namespace ast2._2_
{
    class Program
    {
        static void Main(string[] args)
        {
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

                //Km/h för fort Antal månader
                    //        16 – 20 1mån
                    //21 – 30 2mån
                    //31 – 40 3mån
                    //41 – 50 4mån
                    //51 – 60 5mån
                    //61 – 70 6mån
            }


        }
    }
}
