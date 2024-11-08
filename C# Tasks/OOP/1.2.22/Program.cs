namespace _1._2._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine()!);

            switch (grade)
            {
                case 2: Console.WriteLine("Слаб"); break;
                case 3: Console.WriteLine("Среден"); break;
                case 4: Console.WriteLine("Добър"); break;
                case 5: Console.WriteLine("Много добър"); break;
                case 6: Console.WriteLine("Отличен"); break;

                default: Console.WriteLine("Невалидна оценка"); break;

            }
        }
    }
}