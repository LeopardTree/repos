using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn_array.1
{
                class Program
                {
                        static void Main(string[] args)
                        {
                            int[] randInt = new int[100];
                            Random rand = new Random();
                            for (int i = 0; i < 100; i++)
                            {
                                randInt[i] = rand.Next(1, 100)

                            }
                            while (true) 
                            {

                                Console.WriteLine("Vilket tal vill du söka efter? ")
                                int num = int.Parse(Console.ReadLine());
                                bool found_num = false;
                                for (int i = 0; i < 100; i++)
                                {
                                    if (randInt[i] == num)
                                    {
                                        found_num = true;
                                        break;
                                    }
                                }
                                if (found_num)
                                {
                                    Console.WriteLine($"found {num}")
                                }
                                else
                                {
                                    Console.WriteLine($"didn't find {num}")
                                }
                            }
                        }
                }
}



