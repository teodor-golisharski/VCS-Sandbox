namespace _2._4._12
{
    internal class Program
    {
        static int ans = 0;

        static int[,] a = new int[4, 4];
        static void Main(string[] args)
        {
            Sudoku(0, 0);
            Console.WriteLine(ans);
        }

        static void Sudoku(int x, int y)
        {
            if (x > 3)
            {
                ans++;
                return;
            }
            for (int i = 1; i <= 4; i++)
            {
                if (Check(x, y, i))
                {
                    a[x, y] = i;
                    if (y < 3)
                    {
                        Sudoku(x, y + 1);
                    }
                    else
                    {
                        Sudoku(x + 1, 0);
                    }
                    a[x, y] = 0;
                }
            }
        }

        private static bool Check(int x, int y, int p)
        {
            for (int i = 0; i < y; i++)
            {
                if (a[x, i] == p)
                {
                    return false;
                }
            }
            for (int i = 0; i < x; i++)
            {
                if (a[i, y] == p)
                {
                    return false;
                }
            }
            if (x < 2)
            {
                if (y < 2)
                {
                    if (a[0, 0] == p || a[0, 1] == p || a[1, 0] == p || a[1, 1] == p)
                    {
                        return false;
                    }
                }
                else
                {
                    if (a[0, 2] == p || a[0, 3] == p || a[1, 2] == p || a[1, 3] == p)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (y < 2)
                {
                    if (a[2, 0] == p || a[2, 1] == p || a[3, 0] == p || a[3, 1] == p)
                    {
                        return false;
                    }
                }
                else
                {
                    if (a[2, 2] == p || a[2, 3] == p || a[3, 2] == p || a[3, 3] == p)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}