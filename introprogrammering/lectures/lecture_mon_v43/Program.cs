using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_mon_v43
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0, number1 = 12, number2 = 23;
            //metoder/funktioner

            result = Add(number1, number2);
            Console.WriteLine(result);

            result = Subtract(number1, number2);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int Add(int n1, int n2)
        {
            //int result = n1 + n2;
            //return result;
            return n1 + n2;
        }
        static int Subtract(int n1, int n2)
        {
            //int result = n1 + n2;
            //return result;
            return n1 - n2;
        }
    }
}
