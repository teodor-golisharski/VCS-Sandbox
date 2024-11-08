using System.Data;

namespace _2._3._3
{
    internal class Program
    {
        static int[] row = null!;
        static int n;
        static int p;
        static void Loops(int current)
        {
            if(current >= n)
            {
                Print(); 
                return;
            }
            for (int i = 1; i <= p; i++)
            {
                row[current] = i;
                Loops(current + 1);
            }
        }

        private static void Print()
        {
            for(int i = 0; i < n; i++) 
            {
                Console.Write(row[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            n = int.Parse(Console.ReadLine()!);
            p = int.Parse(Console.ReadLine()!);

            row = new int[n];
            Loops(0);
        }
    }
}