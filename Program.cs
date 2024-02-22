namespace ArchitectArithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rect(10, 5));
            Console.WriteLine(Circle(5));
            Console.WriteLine(Triangle(10, 5));
            double totalArea = Rect(2500, 1500) + Triangle(750, 500) + 0.5 * Circle(375);
            double totalCost = totalArea * 180;
            Console.WriteLine(totalArea);
            Console.WriteLine(totalCost);
            Console.WriteLine($"My plan costs: {Math.Round(totalCost, 2)} pesos.");
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}