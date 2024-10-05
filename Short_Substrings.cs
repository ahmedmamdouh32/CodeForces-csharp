namespace CodeForces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test_cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < test_cases; i++) {
                char[] b = Console.ReadLine().ToCharArray();
                if (b.Length == 1)
                {
                    Console.WriteLine(b[0]);
                }
                else if (b.Length == 2)
                {
                    Console.Write(b[0]);
                    Console.WriteLine(b[1]);
                }
                else if (b.Length > 2)
                {
                    Console.Write(b[0]);
                    for (int j = 2; j <= b.Length - 2; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(b[j]);
                        }
                    }
                    Console.WriteLine(b[b.Length-1]);
                }
            }
        }
    }
}