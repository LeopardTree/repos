using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_metod2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double width = 0, height = 0;
            double area = 0, perimeter = 0, diagonal = 0;
            string userInput = "";
            //ask user for width and height
            Console.Write("Ange rektangelns bredd: ");
            userInput = Console.ReadLine();
            //convert user input
            width = double.Parse(userInput);

            Console.Write("Ange rektangelns höjd: ");
            userInput = Console.ReadLine();
            //convert user input
            height = double.Parse(userInput);
            //check user input

            //calc area
            area = RecArea(width, height);
            //calc perimeter
            perimeter = RecPerimeter(width, height);
            //calc diagonal
            diagonal = RecDiagonal(width, height);
            //print result
            Console.WriteLine("En rektangel med bredden {0} och höjden {1} har", width, height);
            Console.WriteLine("arean = {0}, omkretsen {1} och diagonalen {2}.", area, perimeter, diagonal);
            //paus
            Console.ReadKey();

        }
        //
        //callculate the area of a rectangle
        //
        static double RecArea(double width, double height)
        {
            return width * height;
        }
        //
        //calculate the perimeter of a rectangle
        //
        static double RecPerimeter(double width, double height)
        {
            return 2 * (width + height);
        }
        //
        //calculate diagonal
        //
        static double RecDiagonal(double width, double height)
        {
            return  Math.Sqrt(width* width + height * height);
        }

    }
}
