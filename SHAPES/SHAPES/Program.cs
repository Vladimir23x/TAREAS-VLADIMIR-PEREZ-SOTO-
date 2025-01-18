using System;
using SHAPES;

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(10, 5),
            new Triangle(6, 8),
            new Circle(7)
        };

        double[] areas = new double[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
            Console.WriteLine($"Área del Shape {shapes[i].GetType().Name}: {areas[i]:F2}");
        }
    }
}
