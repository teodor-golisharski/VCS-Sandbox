using System.Text;

namespace _2._5._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()!;

            char[] spliters = new char[] { ' ' };
            string[] arr = text.Split(spliters);

            StringBuilder sb = new StringBuilder();
            foreach (string s in arr)
            {
                string line = s;
                if (s.Contains("upcase"))
                {
                    Stack<char> stack = new Stack<char>();

                    int count = 0;
                    bool flag = false;
                    foreach (var item in line)
                    {
                        if (item == '<')
                        {
                            flag = true;
                        }
                        else if (item == '>')
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                            count = 0;
                            flag = false;
                        }
                        else if(flag)
                        {
                            stack.Push(item);
                            count++;
                        }
                        else
                        {
                            stack.Push(item);
                        }

                    }

                    line = string.Empty;
                    foreach (var item in stack)
                    {
                        line += item;
                    }

                    char[] temp = line.ToCharArray();
                    Array.Reverse(temp);
                    line = new string(temp).ToUpper();
                    
                }
                sb.Append(line + " ");
            }
            Console.WriteLine(sb.ToString().Trim());

        }
    }
}