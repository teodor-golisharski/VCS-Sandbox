namespace _1._2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()!);
            double b = double.Parse(Console.ReadLine()!);

            double res1 = a / b;
            double res2 = Math.Floor(res1);

            Console.WriteLine($"{res2} евро");
            Console.WriteLine($"{Math.Round(Math.Abs(res1 - res2)*b*100)} стотинки");
        }
    }
}