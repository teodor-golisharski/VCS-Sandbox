namespace _1._2._26
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
            ints.Reverse();
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}