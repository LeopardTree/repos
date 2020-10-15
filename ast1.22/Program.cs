using System;

namespace ast1._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //adds foreground and background color to data
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            //clear console so the color appears on all background
            Console.Clear();


            string name = "Ludvig Viveland";
            string street = "Vårbruksgatan 81";
            string zip_city = "58332 Linköping";


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

            Console.SetCursorPosition(20, 20);

            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
                if (i == longeststring + 3)
                {
                    Console.WriteLine("");
                }
            }

            Console.SetCursorPosition(20, 21);

            Console.WriteLine("* {0, -16}  *", name);
            Console.SetCursorPosition(20, 22);
            Console.WriteLine("* {0, -16} *", street);
            Console.SetCursorPosition(20, 23);
            Console.WriteLine("* {0, - 16}  *", zip_city);

            Console.SetCursorPosition(20, 24);
            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
            }

            
            Console.ReadKey();
        }
    
        
    }
}
