namespace _1._2._36
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(0);

            string? input;
            while ((input = Console.ReadLine()) != "")
            {
                int n = int.Parse(input);
                list.Add(n);
            }

            int countPeak = 0;
            int countBottom = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int a;
                int b;

                if (i == 0)
                {
                    a = list[i + 1];
                    b = list[list.Count - 1];
                }
                else if (i == list.Count - 1)
                {
                    a = list[i - 1];
                    b = list[0];
                }
                else
                {
                    a = list[i - 1];
                    b = list[i + 1];
                }

                if (list[i] > a && list[i] > b)
                {
                    countPeak++;
                }
                else if (list[i] < a && list[i] < b)
                {
                    countBottom++;
                } 

            }
            Console.WriteLine($"{countPeak} {countBottom}");
        }
    }
}