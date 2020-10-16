using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array.losn._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ange ett ord eller en text: ");
            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
;
            string revText = new string(charArray);
            Console.WriteLine(revText);

            if(text == revText)
            {
                Console.WriteLine("texten är ett palindrom")
            }
            else
            {
                Console.WriteLine("texten är inte ett palindrom")
            }


            Console.ReadKey();
        }
    }
}
