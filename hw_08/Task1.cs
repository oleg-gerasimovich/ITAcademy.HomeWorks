using System;
using System.Diagnostics;
using System.Collections.Generic;
namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t*****Task1*****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"Напишите стихотворение в одну строку, разделяя строки символом ';'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите только русское стихотворение");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string poem = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            string[] newPoem = poem.Split(';');

            for (int i = 0; i < newPoem.Length; i++)
            {

                    Console.WriteLine(newPoem[i].Replace("а", "о").Replace("А","О"));
            }
        }
    }
}
