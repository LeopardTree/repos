using System;

namespace ast1
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

            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("* " + {0} +" *"; name);

            //Console.WriteLine("*" + "  " + { 0} +" " + "*", street);

            //Console.WriteLine("*" + "" + { 0} +" " + "*", zip_city);

            for (int i = 0; i < longeststring + 4; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
