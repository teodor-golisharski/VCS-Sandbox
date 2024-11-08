namespace _1._3._13
{
    class Container
    {
        private int weight;
        private double height, width, length;
        public Container(int we, double he, double wi, double le)
        {
            this.weight = we;
            this.height = he;
            this.width = wi;
            this.length = le;
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 0)
                {
                    this.weight = value;
                } 
            }
        }
        public double Height 
        { 
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    this.height = value;
                }
            }
        }
        public double Width 
        { 
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    this.width = value;
                }
            }
        }
        public double Length 
        { 
            get { return length; }
            set
            {
                if (value >= 0)
                {
                    this.length = value;
                }
            }
        }

        public double Volume
        {
            get { return Height * Width * Length; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}