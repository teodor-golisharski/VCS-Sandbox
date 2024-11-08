namespace _2._4._3
{
    class Triple : IComparable<Triple>
    {
        public Triple(int numberOne, int numberTwo, int numberThree)
        {
            this.NumberOne = numberOne;
            this.NumberTwo = numberTwo;
            this.NumberThree = numberThree;
        }

        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public int NumberThree { get; set; }

        public int CompareTo(Triple? other)
        {
            if(NumberOne > other!.NumberOne)
            {
                return 1;
            }
            else if(NumberOne < other.NumberOne)
            {
                return -1;
            }
            else
            {
                if(NumberTwo > other.NumberTwo)
                {
                    return 1;
                }
                else if(NumberTwo < other.NumberTwo)
                {
                    return -1;
                }
                else
                {
                    if(NumberThree > other.NumberThree)
                    {
                        return 1;
                    }
                    else if(NumberThree < other.NumberThree)
                    {
                        return -1;
                    }
                    else return 0;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triple> triples = new List<Triple>();  

            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console
                    .ReadLine()!
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int numberOne = tokens[0];
                int numberTwo = tokens[1];
                int numberThree = tokens[2];

                Triple triple = new Triple(numberOne, numberTwo, numberThree);

                triples.Add(triple);
            }

            triples.Sort();

            foreach (var item in triples)
            {
                Console.WriteLine($"{item.NumberOne} {item.NumberTwo} {item.NumberThree}");
            }
        }
    }
}