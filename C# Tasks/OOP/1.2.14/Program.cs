namespace _1._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = int.Parse(Console.ReadLine()!);
            double h = double.Parse(Console.ReadLine()!);

            double l = int.Parse(Console.ReadLine()!);
            double w = double.Parse(Console.ReadLine()!);

            double x = Math.Floor(l / h);
            double res = Math.Ceiling(Math.Ceiling(d / w) / x);
            Console.WriteLine(res);
        }
    }
}