namespace _2._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int grade = int.Parse(Console.ReadLine()!);

                switch (grade)
                {
                    case 2: Console.WriteLine("Слаб"); break;
                    case 3: Console.WriteLine("Среден"); break;
                    case 4: Console.WriteLine("Добър"); break;
                    case 5: Console.WriteLine("Много добър"); break;
                    case 6: Console.WriteLine("Отличен"); break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number");
            }
            
        }
    }
}