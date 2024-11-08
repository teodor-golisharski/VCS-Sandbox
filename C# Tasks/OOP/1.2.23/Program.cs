namespace _1._2._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            string s = n.ToString();
            int[] arr = new int[6];

            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i].ToString());
                if (arr[i] % 2 == 1)
                {
                    x++;
                }
            }
            int res1 = arr[0] * 100 + arr[2] * 10 + arr[4];
            int res2 = arr[4] * 100 + arr[2] * 10 + arr[0];

            int y = (Math.Abs(res1 - res2));

            Console.WriteLine($"{x}{y.ToString("000")}");
        }
    }
}