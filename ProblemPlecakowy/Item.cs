using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Item
    {
        public int value { get; }
        public int weight { get; }
        public int id { get; }

        public override string ToString()
        {
            return $"no. {id}, value: {value}, weight: {weight}";
        }

        public Item(int value, int weight, int id)
        {
            this.value = value;
            this.weight = weight;
            this.id = id;
        }
    }
}
