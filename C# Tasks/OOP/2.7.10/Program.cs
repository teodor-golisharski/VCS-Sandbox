using _1._3._16;

namespace _2._7._10
{
    class BookLibrary
    {
        public BookLibrary()
        {
            Books = new List<Book>();
        }
        public ICollection<Book> Books { get; set; }

        public int Size()
        {
            return Books.Count;
        }
        public void Append(Book b)
        {
            if (Books.Any(x => x.Author == b.Author && b.Title == x.Title))
            {
                //throw
            }
            else
            {
                Books.Add(b);
            }
        }
        public void Delete(string title, string author)
        {
            Book book = Books.FirstOrDefault(x => x.Title == title && x.Author == author)!;

            if (book != null)
            {
                Books.Remove(book);
            }
            else
            {
                //throw;
            }
        }

        public Book GetB(string title)
        {
            return Books.FirstOrDefault(x => x.Title == title)!;
        }
        public Book GetBa(string title, string author)
        {
            return Books.FirstOrDefault(x => x.Title == title && x.Author == author)!;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}