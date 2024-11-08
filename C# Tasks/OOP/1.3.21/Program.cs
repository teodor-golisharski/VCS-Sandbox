namespace _1._3._21
{
    using _1._3._14;
    class Hero
    {
        public Hero(int x, int y, int power, int health)
        {
            X = x; 
            Y = y; 
            Power = power; 
            Health = health;
        }

        public  int X { get; set; }
        public  int Y { get; set; }
        public  int Power { get; set; }
        public  int Health { get; set; }

        public void Eat(Mushroom mushroom)
        {
            double m = Distances.M(X, mushroom.X, Y, mushroom.Y);
            if(m <= Power)
            {
                Health += mushroom.Effect;
            }
        }
    }
    
    class Mushroom
    {
        public Mushroom(int x, int y, int effect)
        {
            X = x;
            Y = y;
            Effect = effect;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Effect { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}