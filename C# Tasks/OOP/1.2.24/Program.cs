namespace _1._2._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 60 sec - green
            // 4 sec - yellow
            // 40 sec - red
            // 4 sec - yellowm

            int c = int.Parse(Console.ReadLine()!);
            int m = int.Parse(Console.ReadLine()!);
            int s = int.Parse(Console.ReadLine()!);

            //int startTime = 8;

            Queue<int> lights = new Queue<int>();
            lights.Enqueue(60);
            lights.Enqueue(4);
            lights.Enqueue(40);
            lights.Enqueue(4);

            int time = c * 60 * 60 + m * 60 + s;

            int current = 0;

            while (current < time)
            {
                int light = lights.Dequeue();
                current += light;
                lights.Enqueue(light);

                if (current >= time)
                {
                    switch (light)
                    {
                        case 60: Console.WriteLine("premini"); break;
                        case 40: Console.WriteLine("spri"); break;
                        case 4: Console.WriteLine("izchakai"); break;
                    }
                }
            }


        }
    }
}