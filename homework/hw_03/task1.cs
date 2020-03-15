using System;

namespace CSPLess3
{
    class Program
    {
        static void Main(string[] args)
        {


            //примеры явного преобразования типов
            byte a = 4;
            byte b = (byte)(a + 70);

            ushort num1 = 20;
            byte num2 = (byte)num1;

            double number1 = 4.0;
            decimal number2 = (decimal)number1;

            //примеры неявного преобразования типов
            sbyte count1 = 45;
            short count2 = count1;

            byte c = 4;
            int d = c + 70;

            int bruh = 2343425;
            long hurb = bruh;

            //примеры упаковки и распаковки

            //1 пример - упаковка int и распаковка в ushort
            int i = 5;
            object @int = i;
            ushort j = (ushort)(int)@int;

            //2 пример - упаковки логического типа и распаковка в byte
            bool r = false;
            object @boolean = r;
            byte w = Convert.ToByte((bool)@boolean);

            //3 пример - упаковка char и распаковка в int
            char e = 'F';
            object @char = e;
            int unbox = (int)(char)@char;



        }
    }
}
