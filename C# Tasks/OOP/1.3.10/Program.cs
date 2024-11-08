namespace _1._3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song();
            Song s2 = new Song("demo123");
            Song s3 = new Song("demo123", "demo123");
            Song s4 = new Song(s3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}