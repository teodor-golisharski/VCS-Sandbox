namespace _1._2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine(string.Join(Environment.NewLine,GetResult(n)));
        }

        static private HashSet<int> GetResult(int n)
        {
            HashSet<int> res = new HashSet<int>();
            //abc = a * 100 + b * 10 + c
            int a = n / 100;
            int b = n / 10 % 10;
            int c = n % 10;

            int[] arr = new int[3];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        res.Add(arr[x] * 100 + arr[y] * 10 + arr[z]);
                    }
                }
            }

            return Filter(res);
        }

        static private HashSet<int> Filter(HashSet<int> res)
        {
            foreach (var item in res)
            {
                int a = item / 100;
                int b = item / 10 % 10;
                int c = item % 10;

                if(a==b || b==c || c==a)
                {
                    res.Remove(item);
                }
            }
            res.OrderBy(x => x);
            return res;
        }
    }
}