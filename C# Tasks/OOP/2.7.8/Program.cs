using Microsoft.Win32;
using System.Text;

namespace _2._7._8
{
    class TextAnalyzer
    {
        public string Text { get; set; } = null!;

        public void InputString (string name)
        {
            StreamReader reader = new StreamReader(name + ".txt");

            using (reader)
            {
                Text = reader.ReadToEnd();
            }
        }

        public string WordFrequences () 
        {
            Dictionary<string, int> register = new Dictionary<string, int>();

            foreach (var item in Text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (register.ContainsKey(item.ToLower()))
                {
                    register[item]++;
                }
                else
                {
                    register.Add(item.ToLower(), 1);
                }
            }
            StringBuilder sb = new StringBuilder();

            foreach (var item in register.OrderBy(x => x.Key))
            {
                sb.Append($"{item.Key} {item.Value}; ");
            }
            return sb.ToString();
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer analyzer = new TextAnalyzer();
        }
    }
}