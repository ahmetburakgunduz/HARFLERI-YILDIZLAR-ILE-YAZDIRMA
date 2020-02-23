using System;

namespace AAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int z = Convert.ToInt16(Console.ReadLine());

            //A
            for (int i = 0; i < z; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < (z - 2) / 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < (z - 2); k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
                Console.WriteLine();
            }
            for (int i = 0; i < z; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < (z - 2) / 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < (z - 2); k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //H

            for (int i = 0; i < (z - 2) / 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < (z - 2); k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
                Console.WriteLine();
            }
            for (int i = 0; i < z; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            for (int i = 0; i < (z - 2) / 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < (z - 2); k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //M
            for (int i = 0; i < z; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();


            for (int i = 0; i < (z - 2) / 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < (z - 2); k++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine(" *");

                for (int k = 0; k < (z - 1); k++)
                {
                    Console.Write("  ");

                }
                Console.WriteLine("*");

            }

            //Console.WriteLine("bir kelime giriniz.");

            //string kelime = Console.ReadLine();
            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime.Substring(i, 1).ToUpper());
            //}
            K_harfi(10);
        }
        static void K_harfi(int a)
            
            {
                for (int i = 0; i < a / 2 ; i++)
                {
                    Console.Write("*");
                    for (int j = a-i * 2 - 1 ; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i < a / 2; i++)
                {
                    Console.Write("*");
                    for (int j = i * 2 - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            
        }
    }

