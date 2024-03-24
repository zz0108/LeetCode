using Dumpify;

namespace LeetCode121Solution
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var buy = prices[0];

            var profit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i])
                    buy = prices[i];

                profit = Math.Max(prices[i] - buy, profit);
            }

            return profit;
        }
    }
}
