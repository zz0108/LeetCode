using LeetCode01Solution;

namespace LeetCode01Test
{
    [TestFixture]
    public class Tests
    {
        private static object[][] _testCase1 =
        [
            [
                new[] { 2,7,11,15 }, 9, new [] {0,1}
            ],
            [
                new[] { 3,2,4 }, 6 , new [] {1 , 2}
            ],
            [
                new [] { 3, 3 } , 6 , new [] {0,1}
            ]
        ];

        [Test]
        [TestCaseSource(nameof(_testCase1))]
        public void TestCase(int[] nums, int target, int[] ans)
        {
            var solution = new Solution();

            var result = solution.TwoSum(nums,target);

            Assert.That(result, Is.EqualTo(ans));
        }
    }
}