using System.Text;

namespace _2._7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> register = new Dictionary<string, int>();
            
            string[] input = Console.ReadLine()!
                .Split(new char[] {' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if(register.ContainsKey(item.ToLower()))
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
            Console.WriteLine(sb.ToString());
        }
    }
}