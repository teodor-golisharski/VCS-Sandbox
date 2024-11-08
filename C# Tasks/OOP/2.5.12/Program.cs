using System.Text.RegularExpressions;

namespace _2._5._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()!;
            string regex = @"<\/?[a-z]+>";
            text = Regex.Replace(text, regex, "");
            Console.WriteLine(text);

        }
    }
}