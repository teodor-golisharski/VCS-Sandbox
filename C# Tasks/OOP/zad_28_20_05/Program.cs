namespace zad_28_20_05
{
    internal class Program
    {
        private static int Sum(int k)
        {
            int sum = 0;
            while (k > 0)
            {
                sum += k % 10;
                k /= 10;
            }
            return sum;
        }

        static List<int> Method1(List<int> list, int k)
        {
            List<int> result = new List<int>(); 

            foreach (int i in list)
            {
                if (Sum(i) % k != 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        static List<int> Method2(List<int> list)
        {
            return list.OrderBy(x => Sum(x)).ToList();
        }

        static List<int> Method3(string fileName)
        {
            List<int> list = new List<int>();
            try
            {
                StreamReader sr = new StreamReader(fileName + ".txt");
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        list.Add(int.Parse(sr.ReadLine()!));
                    }
                    return list;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured!");

                return null!;
            }

            
        }

        static void Main(string[] args)
        {
            string fileName = Console.ReadLine()!;

            int k = int.Parse(Console.ReadLine()!);

            List<int> list = Method3(fileName);

            if (list != null)
            {
                list = Method1(list, k);

                list = Method2(list);

                Console.WriteLine(string.Join(' ', list));
            }
            return;
        }
    }
}