using LeetCode121Solution;

namespace LeetCode121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new[] { 7, 1, 5, 3, 6, 4 };

            var solution = new Solution();

            var maxProfit = solution.MaxProfit(prices);
        }
    }
}
