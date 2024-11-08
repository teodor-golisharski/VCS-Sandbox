namespace zad_26_20_05
{
    class ItemList
    {
        public ItemList()
        {
            Items = new List<Item>();
        }

        public List<Item> Items { get; }

        public int size()
        {
            return Items.Count;
        }

        public Item get(int index)
        {
            if (index < 0 || index >= Items.Count)
            {
                throw new ArgumentOutOfRangeException("Item does not exist!");
            }
            return Items[index];
        }

        public void add(Item item)
        {
            if (Items.Any(x => x.CompareTo(item) == 0))
            {
                throw new ArgumentException("Item already exists!");
            }
            Items.Add(item);
            Items.Sort();
        }
    }


    class Item : IComparable<Item>
    {
        public Item(string description, double price)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("Description cannot be null or empty!");
            }
            Description = description;

            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative!");
            }
            Price = price;
        }

        public string Description { get; } = null!;
        public double Price { get; }

        public int CompareTo(Item? b)
        {
            if (Description.CompareTo(b!.Description) < 0)
            {
                return -1;
            }
            else if (Description.CompareTo(b.Description) > 0)
            {
                return 1;
            }
            else
            {
                if (Price < b.Price)
                {
                    return -1;
                }
                else if (Price > b.Price)
                {
                    return 1;
                }
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Description} ({Price:f2})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ItemList itemList = new ItemList();

                int n = int.Parse(Console.ReadLine()!);

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Item: #{i + 1}");

                    Console.Write($"Description: ");
                    string description = Console.ReadLine()!;

                    Console.Write($"Price: ");
                    double price = double.Parse(Console.ReadLine()!);

                    try
                    {
                        Item item = new Item(description, price);
                        itemList.add(item);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                }

                foreach (var item in itemList.Items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}