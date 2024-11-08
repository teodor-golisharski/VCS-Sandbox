namespace _2._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Random random = new Random();
            List<string> list = new List<string>();

            StreamReader reader = new StreamReader("names.txt");
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine()!;

                    list.Add(line);
                }
            }

            if (list.Count < n)
            {
                Console.WriteLine("Няма достатъчно данни");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int num = random.Next(0, list.Count - 1);
                    Console.WriteLine(list[num]);
                    list.Remove(list[num]);
                }
            }
        }
    }
}