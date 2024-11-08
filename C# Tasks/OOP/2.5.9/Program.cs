namespace _2._5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()!;

            string first = string.Empty;
            string second = string.Empty;

            if (text.Length % 2 == 0)
            {
                first = text.Substring(0, text.Length / 2);
                second = text.Substring(text.Length / 2);
            }
            else
            {
                first = text.Substring(0, text.Length/2);
                second = text.Substring(text.Length/2 + 1);
            }

            char[] arr = second.ToCharArray();
            Array.Reverse(arr);
            second = new string (arr);

            if(first.ToLower() == second.ToLower())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}