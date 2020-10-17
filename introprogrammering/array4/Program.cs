using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array4
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Snart är det haloween.";
            int length = text.Length;

            //char[] textlist = new char[length];
            char oneatatime;
            int i = 0;
            for (i = 0; i <= length -1; i++)
            {
                oneatatime = text[i];
                Console.WriteLine("{0}", text[i]);
                    

            }
            Console.ReadKey();
        }

    }
}
