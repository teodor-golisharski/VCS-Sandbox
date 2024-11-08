
namespace _1._2._35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()!;

            foreach (var item in text)
            {
                if (!char.IsDigit(item))
                {
                    return;
                }
            }
            
            string fh;
            string sh;
            
            if (text.Length % 2 == 0)
            {
                fh = text.Substring(0, text.Length / 2);
                sh = text.Substring(text.Length / 2, text.Length / 2);
            }
            else
            {
                fh = text.Substring(0, text.Length / 2);
                sh = text.Substring(text.Length / 2 + 1, text.Length / 2);
            }
            
            char[] a = sh.ToCharArray();
            Array.Reverse(a);

            sh = new string(a);

            if (fh == sh)
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