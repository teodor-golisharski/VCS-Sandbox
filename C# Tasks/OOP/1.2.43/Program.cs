namespace _1._2._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            HashSet<int> set = new HashSet<int>();

            for (int i = 6; i <= n; i+=2)
            {
                if(Check(i))
                {
                    set.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }

        static bool Check(int n)
        {
            int sum = 1;
            int sqrt = (int)Math.Sqrt(n);

            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    int quotient = n / i;
                    if (quotient != i)
                    {
                        sum += quotient;
                    }
                }
            }
            return sum == n;
        }
    }
}