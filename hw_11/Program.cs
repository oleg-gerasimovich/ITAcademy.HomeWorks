using System;
namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Figurs[] figurs = new Figurs[3] { new Square(), new Triangle(), new Circle()};

            foreach (var shapes in figurs)
            {
                shapes.Area();
                if (shapes !=null && shapes is Figurs)
                    Console.WriteLine($"This is {shapes.nameOfFigure};\nCLR type is {shapes.GetType()};\n" +
                        $"Area of {shapes.nameOfFigure} is {shapes.area}\n");

                else
                    Console.WriteLine("Not a shape");
            }
        }
    }
}
