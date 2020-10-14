using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace apt1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Beräkna avståndet mellan två punkter
            punkt p1 har x koordinat:
            punkt p1 har y koordinat:
            punkt p2 har x koordinat:
            punkt p2 har y koordinat:

            avståndet är: 

            */

            Console.WriteLine("Beräkna avståndet mellan två punkter");

            Console.WriteLine("punkt p1 har x koordinat:");
            double userInputx1 = double.Parse(Console.ReadLine());

            Console.WriteLine("punkt p1 har y koordinat:");
            double userInputy1 = double.Parse(Console.ReadLine());

            Console.WriteLine("punkt p2 har x koordinat:");
            double userInputx2 = double.Parse(Console.ReadLine());

            Console.WriteLine("punkt p2 har y koordinat:");
            double userInputy2 = double.Parse(Console.ReadLine());

            double xLength = Math.Abs(userInputx1 - userInputx2);
            double yLength = Math.Abs(userInputy1 - userInputy2);

            double distanceBetween = Math.Sqrt(xLength * xLength + yLength * yLength);

            Console.WriteLine("avståndet är: {0}", distanceBetween);



            Console.ReadKey();



        }
    }
}
