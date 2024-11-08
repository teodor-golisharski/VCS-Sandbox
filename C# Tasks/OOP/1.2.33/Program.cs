namespace _1._2._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);  
            int d = int.Parse(Console.ReadLine()!);  
            int k = int.Parse(Console.ReadLine()!);

            int pos = 1;
            int sum = 1;

            for (int i = 0; i < k; i++)
            {
                pos = (pos + d) % n;
                sum += (pos == 0 ? n : pos);
            }

            Console.WriteLine(sum);


        }
    }
}