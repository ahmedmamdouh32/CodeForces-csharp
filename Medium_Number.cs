namespace CodeForces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test_cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < test_cases; i++) {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
                Array.Sort(numbers);
                Console.WriteLine(numbers[1]);
            }
        }
    }
}