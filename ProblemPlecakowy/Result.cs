using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Result
    {
        List<int> ids;
        public int weight {  get; set; }
        public int value { get; set; }
        public Result(List<int> ids, int weight, int value) 
        {
            this.ids = ids;
            this.weight = weight;
            this.value = value;
        }

        public override string ToString()
        {
            return $"items: {string.Join(", ", ids)} \nweight: {weight} \nvalue: {value}";
        }

    }
}
