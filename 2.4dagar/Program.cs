using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4dagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en veckodag:");
            day = Console.ReadLine();

            string msg = "";
            switch (userInput)
            {

                case "måndag":
                    msg = "är veckodag nr 1";
                    break;
                case "tisdag":
                    msg = "är veckodag nr 2";
                    break;
                case "onsdag":
                    msg = "är veckodag nr 3";
                    break;
                case "torsdag":
                    msg = "är veckodag nr 4";
                    break;
                case "fredag":
                    msg = "är veckodag nr 5";
                    break;
                case "lördag":
                    msg = "är veckodag nr 6";
                    break;
                case "söndag":
                    msg = "är veckodag nr 7";
                    break;
                    //default
            }
            Console.WriteLine("det är veckodag nr: {0}", msg);

            Console.ReadKey();
        }
    }
}
