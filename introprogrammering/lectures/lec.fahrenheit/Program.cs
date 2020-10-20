using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lec.fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // (char)176 är grader tecknet
            //deklarera variabler
            double inTemp, outTemp;

            string text1 = "";
                //text2 = "";
            char grad = (char)176;
            int choice = 0;

            bool way = true;


            //draw menu [method] (ex)
            /*********************************
             * konvertera temperaturer
             * 
             * från celsius till fahrenheit
             * 
             * 
             */
            //get user menu selection
            while (way = true)
            {


                DrawMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        //Convert from Celsius to Fahrenheit
                        text1 = "celsius";
                        //text2 = "fahrenheit";

                        Console.WriteLine("Write your temperature in {0}:", text1);
                        inTemp = double.Parse(Console.ReadLine());
                        outTemp = CelsiusToFahrenheit(inTemp);
                        Console.WriteLine("Temperature {0}{1}C is {2}F. ", inTemp, grad, outTemp);
                        break;

                    case 2:
                        text1 = "fahrenheit";
                        //text2 = "celsius";

                        Console.WriteLine("Write your temperature in {0}:", text1);
                        inTemp = double.Parse(Console.ReadLine());
                        outTemp = CelsiusToFahrenheit(inTemp);
                        Console.WriteLine("Temperature {0}{1}C is {2}F. ", inTemp, grad, outTemp);
                        break;

                    case 3:
                        text1 = "celsius";
                        //text2 = "kelvin";

                        Console.WriteLine("Write your temperature in {0}:", text1);
                        inTemp = double.Parse(Console.ReadLine());
                        outTemp = CelsiusToFahrenheit(inTemp);
                        Console.WriteLine("Temperature {0}{1}C is {2}F. ", inTemp, grad, outTemp);
                        break;

                    case 4:
                        text1 = "kelvin";
                        //text2 = "fahrenheit";

                        Console.WriteLine("Write your temperature in {0}:", text1);
                        inTemp = double.Parse(Console.ReadLine());
                        outTemp = CelsiusToFahrenheit(inTemp);
                        Console.WriteLine("Temperature {0}{1}C is {2}F. ", inTemp, grad, outTemp);
                        break;

                    case 9:
                        //exit
                        way = false;
                        Console.ReadKey();
                        break;
                    default:
                        //go to start
                        Console.WriteLine("try again:");
                        break;
                }
            }
            Console.ReadKey();

        }
        

        //Menu(1) Convert from Celsius to Fahrenheit [method]
        //För att omvandla Celsius till Fahrenheit: Multiplicera med 9, dividera med 5 och lägg till 32.
        //Menu(2) Convert from Fahrenheit to Celsius [method]
        //För att omvandla Fahrenheit till Celsius: Dra ifrån 32, multiplicera med 5 och dividera med 9.
        //Menu(3) Convert from Celsius to Kelvin [method]

        //Menu(4) Convert from Kelvin to Fahrenheit [method]

        //Menu(9) exit

        //print result

        //stop

        static void DrawMenu()
        {
            Console.WriteLine("Convert between the temperatures Celsius, Fahrenheit and Kelvin. ");
            Console.WriteLine("Choose a menu:");
            Console.WriteLine();
            Console.WriteLine("Menu(1) Convert from Celsius to Fahrenheit");
            Console.WriteLine("Menu(2) Convert from Fahrenheit to Celsius");
            Console.WriteLine("Menu(3) Convert from Celsius to Kelvin");
            Console.WriteLine("Menu(4) Convert from Kelvin to Fahrenheit");
            Console.WriteLine();
            Console.WriteLine("Press 1, 2, 3 or 4 for each menu. Press 9 to exit.");
            
        }

        //static void ConvertMenu(string text1, string text2, double convert)
        //{
        //    Console.WriteLine("Write your temperature in {0}:", text1);
        //    double inTemp = double.Parse(Console.ReadLine());
        //    outTemp = CelsiusToFahrenheit(inTemp);
        //    Console.WriteLine("Temperature {1}{0} is {2}F. ");
        //}


        #region >>>> Temperature calculations
        //temperature converting
        static double CelsiusToFahrenheit(double celsius)
        
        {

            return celsius * 9.0 / 5.0 + 32;
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {

            return (fahrenheit - 32) * 9.0 / 5.0;
        }
        static double CelsiusToKelvin(double celsius)
        {

            return celsius + 273.15;
        }
        static double KelvinToFahrenheit(double kelvin)
        {

            return (kelvin - 273.15) * 9.0 / 5.0 + 32; ;
        }
        #endregion


    }
}



