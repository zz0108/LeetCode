using LeetCode217Solution;

namespace LeetCode217Test
{
    public class Tests
    {
        private static object[][] _testCase1 =
        [
            [
                new[] { 1,2,3,1 }, true
            ],
            [
                new[] { 1,2,3,4 }, false
            ],
            [
                new[] { 1,1,1,3,3,4,3,2,4,2 }, true
            ]
        ];

        [Test]
        [TestCaseSource(nameof(_testCase1))]
        public void TestCase(int[] nums, bool status)
        {
            var solution = new Solution();

            var resStatus = solution.ContainsDuplicate(nums);

            Assert.That(status, Is.EqualTo(resStatus));
        }
    }
}