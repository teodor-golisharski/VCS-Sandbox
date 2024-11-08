namespace _1._2._32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine()!);
                list.Add(a);
            }

            List<int> results = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (list[i] == i + 1)
                {
                    results.Add(list[i]);
                }
            }

            if (results.Count > 1)
            {
                Console.WriteLine(results.Min());
                Console.WriteLine(results.Max());
            }
            else
            {
                Console.WriteLine("0 0");
            }
        }
    }
}