namespace ProblemSolvingTestin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] code = Console.ReadLine().ToCharArray();
            int index = 0;
            while (index < code.Length)
            {
                if (code[index] == '.')
                {
                    index++;
                    Console.Write(0);
                }
                else if (code[index] == '-')
                {
                    index++;
                    if (code[index] == '.')
                    {
                        index++;
                        Console.Write(1);
                    }
                    else
                    {
                        index++;
                        Console.Write(2);
                    }
                }
            }
        }
    }
}