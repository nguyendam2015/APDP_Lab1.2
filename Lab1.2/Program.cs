using System;

namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Triangle(3, 4); // base=3, height=4
            Figure circle = new Circle(5); // radius=5
            Figure rectangle = new Rectangle(6, 7); // width=6, height=7

            Console.WriteLine($"Triangle area: {triangle.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");
            Console.WriteLine($"Rectangle area: {rectangle.Area()}");
        }
    }
}
