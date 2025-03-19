using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Result
    {
        public List<int> ids { get; set; }
        public int weight {  get; set; }
        public int value { get; set; }
        public Result() 
        {
            ids = new List<int>();
            weight = 0;
            value = 0;
        }

        public override string ToString()
        {
            return $"items: {string.Join(", ", ids)} \r\nweight: {weight} \r\nvalue: {value}";
        }

    }
}
