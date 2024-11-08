namespace _1._2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sc = int.Parse(Console.ReadLine()!);
            int sm = int.Parse(Console.ReadLine()!);
            int tc = int.Parse(Console.ReadLine()!);
            int tm = int.Parse(Console.ReadLine()!);

            int c = sc + tc;
            int m = sm + tm;
            
            if(c >= 24)
            {
                c -= 24;
            }

            string mm = string.Empty;
            if(m<10)
            {
                mm = $"0{m}";
            }
            else
            {
                mm = m.ToString();
            }

            string cc = string.Empty;
            if (c < 10)
            {
                cc = $"0{c}";
            }
            else
            {
                cc = c.ToString();
            }

            Console.WriteLine($"{cc}:{mm}");
        }
    }
}