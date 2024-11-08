using System.Text;

namespace _1._2._40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);


            int spaceCount = n - 1;

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(SpaceTyper(spaceCount));

                int maxRow = i * 2 - 1;
                for (int z = 0; z < maxRow; z++)
                {
                    sb.Append("*");
                }
                spaceCount--;

                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        static string SpaceTyper(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < n; j++)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}