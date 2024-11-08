namespace _1._2._34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);

            if(a % 2 == 1)
            {
                a++;
            }
            if(b % 2 == 1)
            {
                b--;
            }

            Console.WriteLine((a + b) / 2);
        }
    }
}