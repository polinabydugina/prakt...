using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Product
    {
        public string weight;
        public string cost;
        public string volume;
        public string name;
        public string fragility;

        public Product(string weight, string cost, string volume, string name, string fragility)
        {

            this.weight = weight;
            this.cost = cost;
            this.volume = volume;
            this.name = name;
            this.fragility = fragility;
        }
    }

    public static class Factory
    {
        public static Product Create(string weight, string cost, string volume, string name, string fragility)
        {
            return new Product(weight, cost, volume, name, fragility);
        }
    }
}
