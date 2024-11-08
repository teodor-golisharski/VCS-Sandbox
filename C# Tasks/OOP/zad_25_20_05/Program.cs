namespace zad_25_20_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            try
            {

                int n = int.Parse(Console.ReadLine()!);
                if (n < 0)
                {
                    throw new ArgumentException("Numbers must be positive!");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Type number: ");
                    int num = int.Parse(Console.ReadLine()!);
                    try
                    {
                        if (num < 0)
                        {
                            throw new ArgumentException("Numbers must be positive!");
                        }
                        if (dict.ContainsKey(num))
                        {
                            dict[num]++;
                        }
                        else
                        {
                            dict.Add(num, 1);
                        }
                    }
                    catch (Exception ex)
                    {
                        i--;
                        Console.WriteLine(ex.Message);
                    }
                }

                foreach (var item in dict)
                {
                    Console.WriteLine($"число: {item.Key}, брой: {item.Value}");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data!");
            }


        }
    }
}