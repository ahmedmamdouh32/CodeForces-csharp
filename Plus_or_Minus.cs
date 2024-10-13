namespace ProblemSolvingTestin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test_cases = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < test_cases; i++)
            {
                string[] user_input = Console.ReadLine().Split(' ');
                int[] user_input_int = Array.ConvertAll(user_input,int.Parse);
                if (user_input_int[0] + user_input_int[1] == user_input_int[2])
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }               
            }
        }
 
    }
}