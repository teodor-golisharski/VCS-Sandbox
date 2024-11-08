namespace _2._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                list.Add(num);
            }

            list = list.OrderBy(x => x).ToList();

            int minDiff = int.MaxValue;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int diff = Math.Abs(list[i] - list[i + 1]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
            Console.WriteLine(minDiff);
        }
    }
}