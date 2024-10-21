namespace ProblemSolvingTestin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test_cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < test_cases; i++)
            {
                int[] distance_array_int = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);
                int Timur_score = distance_array_int[0];
                arrange_array_desc(ref distance_array_int);
                Console.WriteLine(Array.IndexOf(distance_array_int,Timur_score));
            }
        }
 
        public static void swap<T>(ref T n1, ref T n2)
        {
            T temp = n1;
            n1 = n2;
            n2 = temp;
        }
 
        public static void arrange_array_desc(ref int[] arr)
        {
            for (int i = 0; i < arr.Length;     i++)
                {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}