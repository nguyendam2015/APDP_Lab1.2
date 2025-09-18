namespace Lab1._2
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return System.Math.PI * Radius * Radius;
        }
    }
}