using System.Text;

namespace zad28_26_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 23, 15, 16, 9, 11, 17, 31, 1, 8, 13 };
            int f, s, k;
            if (A[0] >= A[1]) { f = A[0]; s = A[1]; }
            else { f = A[1]; s = A[0]; }
            for (k = 2; k < 10; ++k)
            {
                if (A[k] <= s) continue;
                if (A[k] <= f && A[k] > s) s = A[k];
                else { s = f; f = A[k]; }
            }
            Console.WriteLine(s);

        }

        static bool Contains(char[,] matrix, string text)
        {
            char[] temp = text.ToCharArray();
            Array.Reverse(temp);
            string invertedText = new string(temp);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = string.Empty;
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                    if (sb.ToString().Contains(text) || sb.ToString().Contains(invertedText))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static char[,] ReadMatrix(string fileName)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);

                List<string> strings = new List<string>();

                int rows = 0;
                int columns = 0;

                using (reader)
                {
                    string firstLine = reader.ReadLine()!;
                    rows++;
                    strings.Add(firstLine);

                    columns = firstLine.Length;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine()!;
                        
                        if (columns != line.Length)
                        {
                            Console.WriteLine("Invalid format: Matrix is not rectangular!");
                            return null!;
                        }

                        strings.Add(line!);
                        rows++;
                    }
                }

                char[,] matrix = new char[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        matrix[row, col] = strings[row][col];
                    }
                }
                return matrix;
            }
            catch (Exception)
            {
                Console.WriteLine("File not found!");
                return null!;
            }

            
        }

        static List<string> ReadWords(string fileName)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader reader = new StreamReader(fileName);

                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine()!;
                        list.Add(line);
                    }
                }

                return list;
            }
            catch (Exception)
            {
                Console.WriteLine("File not found!");
                return null!;
            }
        }
    }
}