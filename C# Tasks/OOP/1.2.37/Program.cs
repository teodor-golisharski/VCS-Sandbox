namespace _1._2._37
{
    internal class Program
    {
        static int countPeak = 0;
        static int countBottom = 0;

        static int a, b, c;
        static void Main(string[] args)
        {
            //Author's solution - not even working?!?

            int a1, b1;
            string line;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            a1 = a; b1 = b; Method();

            while (true)
            {
                a = b; b=c; 
                if((line = Console.ReadLine()) == null)
                {
                    break;
                }
                c = int.Parse(line); break;
            }

            c = a1; Method(); a = b; b = c; c = b1; Method();

            Console.WriteLine($"{countPeak} {countBottom}");
        }

        static void Method()
        {
            if (b > a && b > c)
            {
                countPeak++;
            }
            else if (b < a && b < c)
            {
                countBottom++;
            }
        }

    }
}