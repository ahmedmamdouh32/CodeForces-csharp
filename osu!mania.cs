namespace ProblemSolvingTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            int test_cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < test_cases; i++)
            {
                int Rows = int.Parse(Console.ReadLine()); //to skip number of rows input
                string[] rhythm = new string[Rows];       //to store rows
                for (int j = 0; j < Rows; j++)
                {
                    rhythm[j] = Console.ReadLine(); 
                }
 
                rhythm = rhythm.Reverse().ToArray();
 
                for (int j = 0; j < rhythm.Length; j++)
                {
                    Console.WriteLine(Array.IndexOf(rhythm[j].ToCharArray(), '#') + 1);
                }
            }
        }
    }
}