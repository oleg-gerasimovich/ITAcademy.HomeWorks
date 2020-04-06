using System;
using System.IO;
namespace CSPhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTYVWXYZ";
            Console.WriteLine(alphabet);
            for (int i = alphabet.Length - 1; i >= 0; i--)
            {
                Console.Write(alphabet[i]);
            }
        }
    }
}
