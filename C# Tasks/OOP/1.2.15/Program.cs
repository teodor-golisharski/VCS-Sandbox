namespace _1._2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);

            int c = int.Parse(Console.ReadLine()!);
            int d = int.Parse(Console.ReadLine()!);

            int s1 = a * b;
            int s2 = c * d;

            Console.WriteLine(Math.Ceiling((double)s1/s2));
        }
    }
}