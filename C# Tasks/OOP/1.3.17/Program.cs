namespace _1._3._17
{
    using _1._3._16;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string line = Console.ReadLine();
            while (line != "")
            {
                string[] tokens = line!.Split();
                Book book = new Book(tokens[0], tokens[1], double.Parse(tokens[2]), "");
                books.Add(book);
                line = Console.ReadLine();
            }
            foreach (Book book in books.OrderBy(x => x.Price)) 
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}