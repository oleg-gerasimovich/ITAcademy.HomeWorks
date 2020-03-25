using System;
using System.Diagnostics;
namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Task2 ****");
            int[] array = new int[10];
            Random random = new Random();
            var sw = new Stopwatch();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            //my reverse method
            sw.Start();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}  ");
            }
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time spent for my reverse method: {sw.Elapsed}");
            Console.WriteLine();

            //ms reverse method
            sw.Start();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
            sw.Stop();
            Console.WriteLine($"Time spent for MS reverse method: {sw.Elapsed}");
        }
    }
}
