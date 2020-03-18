using System;
using System.IO;
namespace CSPhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! You're in my game. Use buttons 'w','s','a','d' to move");
            string way = "wwwdwwaaas";
            string press;
            for (int i = 0; i < way.Length - 1; i++)
            {
               switch (way[i + 1])
               {
                   case 'w':
                       Console.WriteLine("Press w");
                       press = Convert.ToString(Console.ReadLine());
                       if (press != "w")
                       {
                           Console.WriteLine("Wrong button, press w");
                           press = Convert.ToString(Console.ReadLine());
                       }
                       break;
                   case 'd':
                       Console.WriteLine("Press d");
                       press = Convert.ToString(Console.ReadLine());
                       if (press != "d")
                       {
                           Console.WriteLine("Wrong button, press d");
                           press = Convert.ToString(Console.ReadLine());
                       }
                       break;
                   case 's':
                       Console.WriteLine("Press s");
                       press = Convert.ToString(Console.ReadLine());
                       if (press != "s")
                       {
                           Console.WriteLine("Wrong button, press s");
                           press = Convert.ToString(Console.ReadLine());
                       }
                       break;
                   case 'a':
                       Console.WriteLine("Press a");
                       press = Convert.ToString(Console.ReadLine());
                       if (press != "a")
                       {
                           Console.WriteLine("Wrong button, press a");
                           press = Convert.ToString(Console.ReadLine());
                       }
                       break;
                   default:
                       Console.WriteLine("Sth broke down");
                       break;
               }
            }
            Console.WriteLine("Game is over. Take ur treasure");
        }
    }
}
