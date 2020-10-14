using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int items = 10;
            int totalSum = 0;
            int numberofSixes = 0;

            Random rnd = new Random();

            int[] randomNumbers = new int[items];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write("Ange ett tal från 1 till och med 6:");

                    userInput = Console.ReadLine();
                randomNumbers[i] = int.Parse(userInout);

                for (int i = 0; i < randomNumbers.Length; i++)
                {


                }


            }
  
            Console.WriteLine("Summan av talen är" + totalSum);
        }
    }
}
