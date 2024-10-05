namespace ProblemSolvingTestin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] user_input = Console.ReadLine().Split(' ');
            int k = int.Parse(user_input[1]);
            int[] years = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] after_k_years = new int[years.Length];
            for (int i = 0; i < years.Length; i++)
            {
                after_k_years[i] = years[i] + k;
            }
 
            int available_studnets = 0;
 
            for (int i = 0; i < after_k_years.Length; i++)
            {
                if (after_k_years[i] <= 5)
                {
                    available_studnets++;
                }
            }
            Console.WriteLine(available_studnets / 3);
        }
    }
}