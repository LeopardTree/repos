using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1funktioner_skatt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programmet ska fråga användaren efter bruttolönen(lön före skatt) och sedan beräkna nettolönen
            //(lön efter skatt) samt skatten. Därefter ska resultatet skrivas ut.All kod ska placeras i en metod(Kalla
            //den gärna(CalcSalaryTax) och anropas från Main - metoden.
            //För enkelhetens skull beräknar vi bara kommunalskatten och använder skattesatsen 32 %.

            //deklarera variabler(metod1)

            //anropa metod
            CalcSalaryTax();
            // fråga användare efter bruttolön (metod1)

            //beräkna nettolön samt skatten (metod1)

            //skriv ut resultat (metod1)

            //stop
            Console.ReadLine();



        }

        static void CalcSalaryTax()
        {
            int userInput, grossSalary;
            double netSalary, taX;

            Console.WriteLine("Hej. Skriv in din bruttonlön så räknas nettolön samt skatt ut.");
            userInput = int.Parse(Console.ReadLine());
            grossSalary = userInput;
            netSalary = 0.68 * grossSalary;
            taX = 0.32 * grossSalary;

            Console.WriteLine("Nettolönen är {0}", netSalary);
            Console.WriteLine("Skatten är {0}", taX);


        }
    }
}
