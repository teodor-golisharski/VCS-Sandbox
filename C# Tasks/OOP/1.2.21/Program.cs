namespace _1._2._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);

            if (x == y && x == 0)
            {
                Console.WriteLine("O");
            }
            else if(x == 0)
            {
                Console.WriteLine("V");
            }
            else if(y == 0)
            {
                Console.WriteLine("H");
            }
            else if(x > 0 && y > 0)
            {
                Console.WriteLine("I");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("II");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("III");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("IV");
            }
        }
    }
}