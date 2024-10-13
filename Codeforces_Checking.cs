namespace ProblemSolvingTestin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codeforces = "codeforces";
            int test_cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < test_cases; i++)
            {
                string user_input = Console.ReadLine();
                if (codeforces.Contains(user_input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}