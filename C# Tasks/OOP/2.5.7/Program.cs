using System.Numerics;
using System.Text;

namespace _2._5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()!.Split();
            
            long integer = long.Parse(line[0]);
            int n = int.Parse(line[1]);
            int m = int.Parse(line[2]);

            StringBuilder sb = new StringBuilder();
            double result1 = 0;

            string text = integer.ToString();
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            
            text = new string(arr);

            for (int i = 0; i < text.Length; i++)
            {
                result1 += int.Parse(text[i].ToString()) * Math.Pow(n, i);
            }

            if (m == 10)
            {
                Console.WriteLine(result1);
            }
            else
            {
                sb = new StringBuilder();
                while ((int)result1 > 0)
                {
                    int r = (int)result1 % m;
                    sb.Append(r);
                    result1 /= m;
                }
                string s = sb.ToString();
                char[] array = s.ToCharArray();
                Array.Reverse(array);
                s = new string(array);

                Console.WriteLine(s);
            }
        }
    }
}