namespace demo1
{
    class A
    {
        private static int m_counter = 0;
        public A() { m_counter++; }
        public static int getCounter()
        {
            return m_counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            while (a%10 > 0)
            {
                Console.WriteLine(a);
                a /= 10;
            }
        }

    }
}