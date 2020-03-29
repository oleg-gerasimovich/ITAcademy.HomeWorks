using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t*****Task2*****");
            string str = Convert.ToString("Nevertheless it's my sentence");

            Console.WriteLine(str);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deleting the largest word in line");
            DeletingTheLargestWord(str);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Swapped the largest and the smallest word");
            SwappingWords(str);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            CharacterCount(str);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New sort line: ");
            Sort(str);

            Console.ForegroundColor = ConsoleColor.White;
        }

        static string DeletingTheLargestWord(string str)
        {
            int larg = default, index = default;
            string newString = default;
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > larg)
                {
                    larg = strArray[i].Length;
                    index = i;
                }
            }
            for (int i = 0; i < strArray.Length; i++)
            {
                if (i != index && i != strArray.Length - 1)
                    newString += strArray[i] + " ";
                else if (i == strArray.Length - 1)
                    newString += strArray[i];

            }
            Console.WriteLine(newString);
            return newString;
        }

        static string SwappingWords(string str)
        {
            int max = default, min = default, indexMax = default, indexMin = default;
            string newString = default;
            string[] stringArray = str.Split(' ');
            min = stringArray[0].Length;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max)
                {
                    max = stringArray[i].Length;
                    indexMax = i;
                }
                else if (stringArray[i].Length < min)
                {
                    min = stringArray[i].Length;
                    indexMin = i;
                }
            }

            var temp = stringArray[indexMax];
            stringArray[indexMax] = stringArray[indexMin];
            stringArray[indexMin] = temp;

            newString = String.Join(' ', stringArray);
            Console.WriteLine(newString);
            return newString;
        }

        static int CharacterCount(string str)
        {
            int count = default;
            string[] stringArray = str.Split(' ');
            string newString = String.Join("",stringArray);
            char[] arr;
            arr = newString.ToCharArray();

            while (count < arr.Length)
                count++;

            Console.WriteLine($"Symbols without spaces per line: {count}");

            return count;
        }

        static string Sort(string str)
        {
            string[] stringArray = str.Split(' ');
            string newString = default;
            string temp;

            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = stringArray.Length-1; j > i; j--)
                {
                    if (stringArray[j - 1].Length < stringArray[j].Length)
                    {
                        temp = stringArray[j - 1];
                        stringArray[j - 1] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
                Console.WriteLine(stringArray[i]);
            }

            return newString = String.Join(" ", stringArray);
        }
    }
}
