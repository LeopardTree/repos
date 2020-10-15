using System;


namespace _2._4

{ 
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en veckodag:");
            string day = Console.ReadLine();

            string msg = "";
            switch (day)
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
            Console.WriteLine((msg));

            Console.ReadKey();
        }
    }
}
