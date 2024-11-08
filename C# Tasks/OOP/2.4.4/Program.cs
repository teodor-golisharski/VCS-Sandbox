namespace _2._4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine()!);

                ints.Add(num);
            }

            ints.Sort();
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}