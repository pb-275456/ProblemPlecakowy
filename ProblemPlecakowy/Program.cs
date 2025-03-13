namespace ProblemPlecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seed: ");
            int seed = int.Parse(Console.ReadLine());
            Problem p = new Problem(10, seed);
            Result result = p.Solve(20);
            Console.WriteLine(p.ToString());
            Console.WriteLine(result.ToString());
        }
    }
}
