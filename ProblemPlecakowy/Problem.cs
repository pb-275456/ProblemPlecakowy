using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace ProblemPlecakowy
{
    internal class Problem
    {
        int n;
        int seed;
        public List<Item> items { get; }

        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            this.items = new List<Item>();
            Random random = new Random(seed);


            for(int i = 0; i<n; i++)
            {
                int v = random.Next(1, 10);
                int w = random.Next(1, 10);

                items.Add(new Item(v, w, i));
            }
        }

        public override string ToString()
        {
            return $"items:\n"+ string.Join("\n", items);
        }

        public Result Solve(int capacity)
        {
            var sorted = items.OrderByDescending(i => (double)(i.value/i.weight)).ToList();
            Result result = new Result();
            int leftSpace = capacity;
            foreach (Item i in sorted)
            {
                if (leftSpace >= i.weight)
                {
                    result.value += i.value;
                    result.weight+=i.weight;
                    result.ids.Add(i.id);
                    leftSpace-=i.weight;
                }
            }


            return result;
        }

    }
}
