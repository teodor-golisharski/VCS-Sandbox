using System.Text;

namespace _1._2._20
{
    internal class Program
    {
        const int maxHours = 23;
        const int defMax = 59;

        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()!);
            int minutes = int.Parse(Console.ReadLine()!);
            int seconds = int.Parse(Console.ReadLine()!);


            if (hours > maxHours || minutes > defMax || seconds > defMax)
            {
                Console.WriteLine("Некоректни данни");
                return;
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
    }
}