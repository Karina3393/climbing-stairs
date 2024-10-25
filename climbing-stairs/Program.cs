namespace climbing_stairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            int first = 1, second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


            Console.WriteLine(solution.ClimbStairs(1));
            Console.WriteLine(solution.ClimbStairs(2));
            Console.WriteLine(solution.ClimbStairs(3));
            Console.WriteLine(solution.ClimbStairs(4));
            Console.WriteLine(solution.ClimbStairs(5));
        }
    }
}
