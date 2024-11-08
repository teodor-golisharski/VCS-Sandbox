namespace Algorithms
{
    internal class Program
    {
        static bool BinarySearch(List<int> list, int a)
        {
            int right = list.Count - 1;
            int left = 0;
            int middle;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (list[middle] == a)
                {
                    return true;
                }
                else if (list[middle] > a)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return false;
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            return array;
        }
        public static string Change(bool check)
        {
            if (check = true) return "true";
            else return "false";
        }


        static bool IsOnHorizontаlBorder(int x, int y, int x1, int y1, int x2, int y2)
        {
            bool onUpperLine = (y == y1) && (x >= x1) && (x <= x2);
            bool onLowerLine = (y == y2) && (x >= x1) && (x <= x2);
            return (onUpperLine || onLowerLine);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Change(false));
        }
    }
}