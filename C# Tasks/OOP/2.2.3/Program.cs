namespace _2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxHours = 23;
            const int defMax = 59;

            try
            {
                int hours = int.Parse(Console.ReadLine()!);
                int minutes = int.Parse(Console.ReadLine()!);
                int seconds = int.Parse(Console.ReadLine()!);


                if (hours > maxHours || minutes > defMax || seconds > defMax)
                {
                    throw new ArgumentException("Invalid data!");
                }

                seconds += 1;
                if (seconds > defMax)
                {
                    seconds = 0;
                    minutes += 1;
                }
                if (minutes > defMax)
                {
                    minutes = 0;
                    hours += 1;
                }
                if (hours > maxHours)
                {
                    hours = 0;
                }

                Console.WriteLine($"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}