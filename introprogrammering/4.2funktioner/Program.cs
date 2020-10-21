using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2funktioner
{
    class Program
    {
        
            //Gör som i uppgift 4:1 men placera användarens input i main-klassen och anropa metoden
            //(CalcSaloryTax) med en input - parameter innehållande bruttolönen. Utskriften ska vara kvar
            //i CalcSaloryTax

            static void Main(string[] args)
            {
                int userInput;
                Console.WriteLine("Hej. Skriv in din bruttonlön så räknas nettolön samt skatt ut.");
                userInput = int.Parse(Console.ReadLine());

                CalcSalaryTax(userInput);

                Console.ReadKey();
            }

            static void CalcSalaryTax(int userInput)
            {
                int grossSalary;
                double netSalary, taX;

                grossSalary = userInput;
                netSalary = 0.68 * grossSalary;
                taX = 0.32 * grossSalary;

                Console.WriteLine("Nettolönen är {0}", netSalary);
                Console.WriteLine("Skatten är {0}", taX);


            }
        
    }
}
