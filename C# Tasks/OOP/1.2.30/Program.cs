namespace _1._2._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            List<int> list = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int a = list.OrderBy(x => x).First();
            list.Remove(a);
            int b = list.OrderBy(x => x).First();

            Console.WriteLine($"{a} {b}");
        }
    }
}