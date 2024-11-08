namespace _1._3._23
{
    interface Task
    {
       public DateTime DateTime { get; set; }

    }

    class OneTime 
    {
        public DateTime DateTime { get; set; }
    }
    class Daily
    { 
        public DateTime DateTime { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}