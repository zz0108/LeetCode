using Dumpify;

namespace LeetCode122Solution
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var dp = new int[prices.Length,prices.Length];

            for (var i = 0; i < prices.Length; i++)
            {
                dp[i, i] = prices[i];

                dp.Dump();

                for (var j = 0; j < i; j++)
                {
                    dp[i, j] = prices[i] - prices[j];
                }
            }

            return 0;
        }
    }
}
