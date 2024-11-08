namespace _1._2._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            List<Path> paths = new List<Path>();

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine()!);
                int d = int.Parse(Console.ReadLine()!);

                Path path = new Path()
                {
                    M = m,
                    D = d
                };

                paths.Add(path);
            }
            
            paths.OrderBy(x => x.M).ThenBy(x => x.D);
            
            Path result = paths.OrderBy(x => x.M).ThenBy(x => x.D).First();
            Console.WriteLine($"{result.M} {result.D}");
        }
    }

    class Path
    {
        public int M { get; set; }
        public int D { get; set; }
    }
}