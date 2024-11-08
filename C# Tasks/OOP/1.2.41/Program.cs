namespace _1._2._41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine()!);
            int month = int.Parse(Console.ReadLine()!);
            int year = int.Parse(Console.ReadLine()!);
            
            int addition = int.Parse(Console.ReadLine()!);

            DateTime dt = new DateTime(year, month, day);
            dt = dt.AddDays(addition);

            Console.WriteLine(dt.ToString("dd:MM:yy"));
        }
    }
}