namespace _2._3._2B
{
    internal class Program
    {
        static double X;
        static double Recursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return 1 / Math.Pow(X, n) + Recursion(n - 1);
            }

        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()!);

            X = double.Parse(Console.ReadLine()!);

            double res = Recursion(n);

            Console.WriteLine(res);
        }
    }
}