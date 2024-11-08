using System.Text.RegularExpressions;

namespace _2._5._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mask = "***";

            //string line = Console.ReadLine()!;
            //string[] words = Console.ReadLine()!.Split(", ");

            //HashSet<string> set = new HashSet<string>();
            //for (int i = 0; i < words.Length; i++)
            //{
            //    set.Add(words[i].ToLower());
            //}

            //string newLine = line.ToLower();
            //foreach (string word in set)
            //{
            //    newLine = line.Replace(word, mask);
            //}

            //Console.WriteLine(newLine);

            try
            {
                string text = Console.ReadLine()!;
                string forbiden = Console.ReadLine()!;
                string rege = Regex.Replace(forbiden, ",", "|");
                string rege1 = rege.ToUpper();
                text = Regex.Replace(text, rege, "***");
                text = Regex.Replace(text, rege1, "***");
                Console.WriteLine(text);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}