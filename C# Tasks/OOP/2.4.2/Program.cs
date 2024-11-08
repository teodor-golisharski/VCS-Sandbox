namespace _2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()!);

            KeyValuePair<int, int>[] keyValuePair = new KeyValuePair<int, int>[n];

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console
                    .ReadLine()!
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                KeyValuePair<int, int> keyValue = new KeyValuePair<int, int>(tokens[0], tokens[1]);

                keyValuePair[i] = keyValue;
            }

            keyValuePair = keyValuePair.OrderBy(kvp => kvp.Key).ThenBy(x => x.Value).ToArray();

            foreach (var item in keyValuePair)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}