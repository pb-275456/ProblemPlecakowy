
namespace ProblemPlecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Problem p = new Problem(n, seed);
            Result result = p.Solve(capacity);
            Console.WriteLine(p.ToString());
            Console.WriteLine(result.ToString());
        }
    }
}
