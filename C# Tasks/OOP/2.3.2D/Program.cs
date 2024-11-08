namespace _2._3._2D
{
    internal class Program
    {
        static double Recursion(int n)
        {
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return n * (n - 1) + Recursion(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            double res = Recursion(n);
            Console.WriteLine(res);
        }
    }
}