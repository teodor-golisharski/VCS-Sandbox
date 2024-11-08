namespace _1._2._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade1 = int.Parse(Console.ReadLine()!);
            int grade2 = int.Parse(Console.ReadLine()!);
            int grade3 = int.Parse(Console.ReadLine()!);
            int grade4 = int.Parse(Console.ReadLine()!);

            List<int> list = new List<int>();
            list.AddRange(new int[] { grade1, grade2, grade3, grade4 });

            if (list.Contains(2))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in list)
                {
                    if (item == 6)
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}