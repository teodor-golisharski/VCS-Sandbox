namespace _1._2._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            int c = int.Parse(Console.ReadLine()!);

            List<int> ints = new List<int>();
            ints.AddRange(new int[] { a, b, c });
            ints.Sort();
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}