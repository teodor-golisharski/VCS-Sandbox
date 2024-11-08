namespace _1._3._18
{
    public class Starship
    {
        public Starship(double maxSpeed, int weaponsPower, int shield, int x, int y, int integrity)
        {
            this.MaxSpeed = maxSpeed;
            this.WeaponsPower = weaponsPower;
            this.Shield = shield;
            this.X = x;
            this.Y = y;
        }

        private double maxSpeed;
        private int weaponsPower;
        private int shield = 100;
        private int x;
        private int y;
        private int integrity = 100;

        public double MaxSpeed 
        {
            get { return maxSpeed; }
            set { maxSpeed = value; } 
        }
        public int WeaponsPower
        {
            get { return weaponsPower; }
            set { weaponsPower = value; }
        }
        public int Shield
        {
            get { return shield; }
            set { shield = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Integrity
        {
            get { return integrity; }
        }

        public void Attack(Starship enemy)
        {
            enemy.Shield -= weaponsPower;
            if(enemy.Shield < 0)
            {
                enemy.integrity += enemy.Shield;
                enemy.shield = 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}