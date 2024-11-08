namespace _2._3._2C
{
    internal class Program
    {
        static double x;
        static double Recursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(x, n) + Recursion(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            x = 1;

            double res = Recursion(n);

            Console.WriteLine(res);
        }
    }
}