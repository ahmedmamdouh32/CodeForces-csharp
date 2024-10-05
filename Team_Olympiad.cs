namespace CodeForces
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            int n = int.Parse(Console.ReadLine());
            int[] subjects = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
 
            Stack<int> Programming = new Stack<int>();
            Stack<int> Math = new Stack<int>();
            Stack<int> PE = new Stack<int>();
            
            for (int i = 1; i <= subjects.Length; i++)
            {
                switch (subjects[i - 1])
                {
                    case 1:
                        Programming.Push(i);
                        break;
                    case 2:
                        Math.Push(i);
                        break;
                    case 3:
                        PE.Push(i);
                        break;
                }
            }
            int max_teams = min(min(Programming.Count, Math.Count), PE.Count);
 
            Console.WriteLine(max_teams);
 
            for (int i = 0; i < max_teams; i++)
            {
                Console.Write(Programming.Pop());
                Console.Write(' ');
                Console.Write(Math.Pop());
                Console.Write(' ');
                Console.Write(PE.Pop());
                Console.WriteLine(' ');
            }
        }
        public static int min(int n1,int n2)
        {
            if (n1 < n2)
                return n1;
            else
                return n2;
        }
    }
}