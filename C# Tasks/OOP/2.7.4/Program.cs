namespace _2._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] box = new int[130, 130];
            int[] arrayInput = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = arrayInput[0];
            int m = arrayInput[1];
            int c = arrayInput[2];

            for (int i = 0; i < c; i++)
            {
                int[] coordinates = Console.ReadLine()!
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int x = coordinates[0];
                int y = coordinates[1];
                box[x, y] = -1;
            }

            string line = Console.ReadLine()!;
            string[] tokens = line.Split(' ');
            int startX = int.Parse(tokens[0]);
            int startY = int.Parse(tokens[1]);

            line = Console.ReadLine()!;
            tokens = line.Split(' ');
            int finalX = int.Parse(tokens[0]);
            int finalY = int.Parse(tokens[1]);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startX);
            queue.Enqueue(startY);
            box[startX, startY] = 1;

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();
                int y = queue.Dequeue();

                if (x == finalX && y == finalY)
                {
                    Console.WriteLine(box[x, y]);
                    return;
                }

                if (x - 1 >= 1 && box[x - 1, y] == 0)
                {
                    box[x - 1, y] = box[x, y] + 1;
                    queue.Enqueue(x - 1);
                    queue.Enqueue(y);
                }

                if (x + 1 <= n && box[x + 1, y] == 0)
                {
                    box[x + 1, y] = box[x, y] + 1;
                    queue.Enqueue(x + 1);
                    queue.Enqueue(y);
                }

                if (y - 1 >= 1 && box[x, y - 1] == 0)
                {
                    box[x, y - 1] = box[x, y] + 1;
                    queue.Enqueue(x);
                    queue.Enqueue(y - 1);
                }

                if (y + 1 <= m && box[x, y + 1] == 0)
                {
                    box[x, y + 1] = box[x, y] + 1;
                    queue.Enqueue(x);
                    queue.Enqueue(y + 1);
                }
            }
            Console.WriteLine("Няма път");
        }
    }
}