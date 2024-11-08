using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._12
{
    public class SmartPhone
    {
        public SmartPhone()
        {
            
        }

        public SmartPhone(string manufacterer, string model, double bandwidth, double price)
        {
            Manufacterer = manufacterer;
            Model = model;
            Bandwidth = bandwidth;
            Price = price;
        }

        public string Manufacterer { get; set; } = null!;
        public string Model { get; set; } = null!;
        public double Bandwidth { get; set; }
        public double Price { get; set; }

        public string PrintPhone()
        {
            return $"Manufacterer: {Manufacterer} \n" +
                   $"Model: {Model} \n" +
                   $"Bandwidth: {Bandwidth} \n" +
                   $"Price: {Price}";
        }
    }
}
