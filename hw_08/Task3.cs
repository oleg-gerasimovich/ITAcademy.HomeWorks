using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace CSPlections
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?", 23);
            int count = 0;

            int firstIndex = str.ToString().IndexOf('?');
            int lastIndex = str.ToString().LastIndexOf('?');

            for (int i = firstIndex + 1; i < lastIndex; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                    str[i] = '_';
            }

            for (int i = 0; i < firstIndex - count;)
            {
                if (str[i] == '!' || str[i] == '.')
                {
                    str.Remove(i, 1);
                    count++;
                }
                else
                    i++;
            }
            Console.WriteLine(str);
        }
    }
}
