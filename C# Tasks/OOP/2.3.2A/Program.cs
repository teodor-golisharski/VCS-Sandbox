namespace _2._3._2A
{
    internal class Program
    {
        static double Recursion(int n)
        {
            if(n == 0)
            {
                return Math.Sqrt(n);
            }
            else
            {
                return Math.Sqrt(n + Recursion(n - 1));
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