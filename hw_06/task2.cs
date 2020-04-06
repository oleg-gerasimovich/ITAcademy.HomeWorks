using System;

namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Task2 ****");
            int[] array = new int[5];

            ConsoleColor pervColor = Console.ForegroundColor;
            for (int i = 0; i < array.Length -1; i++)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Enter the {i+1} element of the second array: ");
                Console.ForegroundColor = pervColor;
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}\t ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Plese, enter the last array element: ");
            Console.ForegroundColor = pervColor;
            int lastElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the index of this element: ");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = lastElement;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
