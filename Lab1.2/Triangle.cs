namespace Lab1._2
{
    public class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public override double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}