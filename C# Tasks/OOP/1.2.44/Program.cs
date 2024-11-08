namespace _1._2._44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int a = 0;
            int b = 1;

            int count = 2;

            bool flag = false;
            if (n > 2)
            {
                int c = a + b;
                while (n > c)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    count++;

                    if (c == n)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if(flag)
            {
                Console.WriteLine($"{count} {a} {b}");
            } 
            else
            {
                Console.WriteLine("Не е число на Фибоначи");
            }
        }
    }
}