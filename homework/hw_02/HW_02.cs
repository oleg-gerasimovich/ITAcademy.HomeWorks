//1.создание переменной и указание ссылки на файл
//2.считываение информации из файла image.txt
//3.разделение строки на строковые массивы
//4.создание массива для будущего переводы бинарных строк в изображение
//5.в цикле создание новой переменной и преобразование в ней бинарного
//кода в картинку
//6.создание файла с картинкой
//7.очистка мусора
using System;
using System.IO;
namespace CSPhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"/Users/oleggerasimovich/Desktop/image.txt", true);
            string textReaderResault = textReader.ReadToEnd();
            string[] arrayOfTextResault = textReaderResault.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResault.Length - 1];
            for (int i=0; i< arrayOfTextResault.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResault[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"/Users/oleggerasimovich/Desktop/converted.png", imageBytes);
            textReader.Dispose();
        }
    }
}
