using System.Text;

namespace _2._7._5
{
    class Apple
    {
        public Apple(int x, int y)
        {
            X = x; Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static int n;
        static int m;
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToArray();

            n = arrayInput[0];
            m = arrayInput[1];
            int c = arrayInput[2];

            int[,] matrix = new int[n, m];

            int count = 0;

            Queue<Apple> spoilt = new Queue<Apple>();
            for (int i = 0; i < c; i++)
            {
                int[] coordinates = Console.ReadLine()!
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int x = coordinates[0];
                int y = coordinates[1];

                Apple apple = new Apple(x, y);
                spoilt.Enqueue(apple);

                matrix[x, y] = 1;
            }


            while (true)
            {
                int spoiltCount = spoilt.Count();
                for (int i = 0; i < spoiltCount; i++)
                {
                    Apple apple = spoilt.Dequeue();
                    int x = apple.X; int y = apple.Y;

                    if (SafeToMove(x + 1, y))
                    {
                        matrix[x + 1, y] = 1;

                        Apple apple1 = new Apple(x + 1, y);

                        spoilt.Enqueue(apple1);
                    }

                    if (SafeToMove(x - 1, y))
                    {
                        matrix[x - 1, y] = 1;

                        Apple apple1 = new Apple(x - 1, y);

                        spoilt.Enqueue(apple1);
                    }

                    if (SafeToMove(x, y + 1))
                    {
                        matrix[x, y + 1] = 1;

                        Apple apple1 = new Apple(x, y + 1);

                        spoilt.Enqueue(apple1);
                    }

                    if (SafeToMove(x, y - 1))
                    {
                        matrix[x, y - 1] = 1;

                        Apple apple1 = new Apple(x, y - 1);

                        spoilt.Enqueue(apple1);
                    }
                }

                count++;

                if(ControlCheck(matrix))
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }

        static bool SafeToMove(int x, int y)
        {
            if (x >= 0 && x < n && y >= 0 && y < m)
            {
                return true;
            }
            return false;
        }

        static bool ControlCheck(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                }
                if (sb.ToString().Contains('0'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}