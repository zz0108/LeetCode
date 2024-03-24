using LeetCode121Solution;

namespace LeetCode121Test
{
    [TestFixture]
    public class Tests
    {
        private static object[][] _testCase1 =
        [
            [
                new[] { 7,1,5,3,6,4 }, 5
            ],
            [
                new[] { 7,6,4,3,1 }, 0
            ]
        ];

        [Test]
        [TestCaseSource(nameof(_testCase1))]
        public void TestCase(int[] prices, int maxProfit)
        {
            var solution = new Solution();

            var profit = solution.MaxProfit(prices);

            Assert.That(profit, Is.EqualTo(maxProfit));
        }
    }
}