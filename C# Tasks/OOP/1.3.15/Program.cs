using _1._3._14;

namespace _1._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()!);   
            double x2 = double.Parse(Console.ReadLine()!);   
            
            double y1 = double.Parse(Console.ReadLine()!);   
            double y2 = double.Parse(Console.ReadLine()!);

            Console.Write($"{Distances.E(x1, x2, y1, y2)} {Distances.M(x1, x2, y1, y2)} {Distances.C(x1, x2, y1, y2)}");
        }
    }
}