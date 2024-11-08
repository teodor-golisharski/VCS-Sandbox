namespace _1._3._16
{
    public class Book
    {
        public Book(string title, string author, double price, string genre)
        {
            if(title == "")
            {
                throw new ArgumentException("Empty string");
            }
            this.title = title;
            this.author = author;
            this.genre = genre;

            if(price < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative");
            }
            this.price = price;
        }

        private string title;
        private string author;
        private double price;
        private string genre;

        public string Title { get { return title; } } 
        public string Author { get { return author; } } 
        public double Price { get { return price; } }
        public string Genre { get { return genre; } }

        public override string ToString()
        {
            return $"{Title} от {Author}, {Price:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}