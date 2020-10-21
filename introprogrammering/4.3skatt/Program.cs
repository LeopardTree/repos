using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3skatt
{
    class Program
    {
        //Utgå från övning 4:2 och gör så att utskriften placeras i Main-metoden. Det innebär att
        //metoden CalcSaloryTax() måste returnera en sträng innehållande resultatet.
        //
        static void Main(string[] args)
        {
            int userInput;
            string netsalary_tax;
            Console.WriteLine("Hej. Skriv in din bruttonlön så räknas nettolön samt skatt ut.");
            userInput = int.Parse(Console.ReadLine());

            netsalary_tax = CalcSalaryTax(userInput);
            Console.WriteLine($"{netsalary_tax}");
            Console.ReadKey();
        }

        static string CalcSalaryTax(int userInput)
        {
            int grossSalary;
            double netSalary, taX;
            string netsalary_tax;

            grossSalary = userInput;
            netSalary = 0.68 * grossSalary;
            taX = 0.32 * grossSalary;

            netsalary_tax = $"Nettolönen är {netSalary} och skatten är {taX}";

            return netsalary_tax;



        }
    }
}