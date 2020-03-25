using System;

namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Task1 ****");
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] sumArray = new int[5];
            Random random = new Random();
            ConsoleColor pervColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We have two arrays, that need to be added: ");
            Console.ForegroundColor = pervColor;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(100);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]}\t ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Enter the {i+1} element of the second array: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The sum of the elements of the two arrays is: ");
            Console.ForegroundColor = pervColor;
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = array1[i] + array2[i];
                Console.Write($"{sumArray[i]}\t ");
            }
        }
    }
}
