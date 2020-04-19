using System;

namespace NewProject
{
    public class Figurs
    {
        public double Side { get; set; }

        public double area { get; set; }

        public string nameOfFigure { get; set; }

        public virtual void Area()
        {
            Console.WriteLine("Enter side (radius): ");
            Side = Convert.ToDouble(Console.ReadLine());
        }

        public Figurs()
        {
        }
    }

    public class Square : Figurs
    {
        Figurs figurs = new Figurs();

        public override void Area()
        {
            base.Area();
            nameOfFigure = "square";
            area = Side * Side;

        }
    }

    public class Triangle : Figurs
    {
        Figurs figurs = new Figurs();

        public override void Area()
        {
            base.Area();
            nameOfFigure = "triangle";
            Console.WriteLine("Enter height: ");
            double height = Convert.ToInt32(Console.ReadLine());
            area = Side * height * 0.5;
        }
    }

    public class Circle : Figurs
    {
        Figurs figurs = new Figurs();

        public override void Area()
        {
            base.Area();
            nameOfFigure = "Circle";
            double radius = Side;
            area = Math.PI * radius * radius;
        }
    }
}
