namespace _1._3._14
{
    public static class Distances
    {
        public static double E(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public static double M(double x1, double x2, double y1, double y2)
        {
            return Math.Abs(x1-x2)+Math.Abs(y1-y2);
        }

        public static double C(double x1, double x2, double y1, double y2)
        {
            return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}