
namespace _1._2._42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            int p = int.Parse(Console.ReadLine()!);

            for (int a = 1; ; a++)
            {
                for (int b = a; ; b++)
                {
                    if (b > p - a - b)
                    {
                        break;
                    }
                    int c = p - a - b;

                    if (a == b && b == c)
                    {
                        count1++;
                    }
                    else if (a == b || a == c || b == c)
                    {
                        count2++;
                    }
                    else
                    {
                        count3++;
                    }
                }
                if (3 * (a + 1) > p)
                {
                    break;
                }
            }
            Console.WriteLine($"{count3} {count2} {count1}");
        }
    }


}