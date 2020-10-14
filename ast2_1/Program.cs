using System;

namespace ast2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange cirkelns diameter: ");

            double userInput = double.Parse(Console.ReadLine());

            Console.WriteLine("En cirkel med diametern {0} har: ", userInput);

            double circumference = Math.PI * userInput;

            Console.WriteLine("omkretsen: {0}", circumference.ToString("F3"));

            Console.WriteLine("En cirkel med diametern {0} har: ", userInput);

            //Console.WriteLine("... omkretsen: " + perimeter.ToString("F2"));

            double area = Math.PI * userInput / 2;
            Console.WriteLine("arean: {0}", area.ToString("F3"));

            Console.ReadKey();
        }
    }
}
