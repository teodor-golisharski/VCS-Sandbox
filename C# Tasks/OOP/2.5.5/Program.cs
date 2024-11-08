using System.Globalization;

namespace _2._5._5
{
    internal class Program
    {
        static int count;
        static int[,] matrix = new int[6, 6];
        static void Main(string[] args)
        {

            int i, j;
            int maxdom = 0;
            for (i = 0; i < 6; i++)
            {
                matrix[i, 0] = matrix[i, 5] = matrix[0, i] = matrix[5, i] = -1;
            }
            for (i = 0; i < 4; i++)
            {
                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                for (j = 0; j < 4; j++)
                {
                    matrix[i + 1, j + 1] = numbers[j];
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (matrix[i, j] != -1)
                    {
                        count = 0;
                        Research(matrix[i, j], i, j);
                        if (count > maxdom)
                        {
                            maxdom = count;
                        }
                    }
                }
            }
            Console.WriteLine(maxdom);
        }
        static void Research(int c, int x, int y)
        {
            matrix[x, y] = -1;
            count++;
            if (matrix[x, y - 1] == c)
            {
                Research(c, x, y - 1);
            }
            if (matrix[x, y + 1] == c)
            {
                Research(c, x, y + 1);
            }
            if (matrix[x - 1, y] == c)
            {
                Research(c, x - 1, y);
            }
            if (matrix[x + 1, y] == c)
            {
                Research(c, x + 1, y);
            }
        }
    }
}