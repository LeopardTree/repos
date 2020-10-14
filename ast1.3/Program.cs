using System;

namespace ast1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            //clear console so the color appears on all background
            Console.Clear();


            string name = "Ludvig Viveland";
            string street = "Vårbruksgatan 81";
            string zip_city = "58332 Linköping";

            Console.Write("Ange antal tecken från vänsterkanten:");
            int userInputX = int.Parse(Console.ReadLine());

            Console.Write("Ange antal tecken från fönstrets övre kant:");
            int userInputY = int.Parse(Console.ReadLine());

            //commasign performs a newline between data


            //the length of the strings in integers
            int longeststring = 0;

            //Console.WriteLine(length_zip_city);

            if (name.Length > street.Length)
            {
                longeststring = name.Length;

            }
            else
            {
                longeststring = street.Length;

            }
            if (longeststring < zip_city.Length)
            {
                longeststring = zip_city.Length;
            }

            //Console.WriteLine("the longest string are {0} characters long", longeststring);

            Console.SetCursorPosition(userInputX, userInputY);

            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
                if (i == longeststring + 3)
                {
                    Console.WriteLine("");
                }
            }

            Console.SetCursorPosition(userInputX, userInputY+1);

            Console.WriteLine("* {0}  *", name);
            Console.SetCursorPosition(userInputX, userInputY + 2);
            Console.WriteLine("* {0} *", street);
            Console.SetCursorPosition(userInputX, userInputY +3);
            Console.WriteLine("* {0}  *", zip_city);

            Console.SetCursorPosition(userInputX, userInputY +4);

            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
