namespace _1._3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Jorge");

            NameChanger changer = new NameChanger();
            changer.ChangeName(ref client.Name, "Gogi");

            Console.WriteLine(client.Name);
        }
    }
}