using LeetCode79Solution;

namespace LeetCode79Test
{
    [TestFixture]
    public class LeetCode79Tests
    {
        private static object[][] _testCase1 =
        [
            [
                new char[][] { ['A', 'B', 'C', 'E'], [ 'S', 'F', 'C', 'S' ], [ 'A', 'D', 'E', 'E' ] }, "ABCCED",true
            ],
            [
                new char[][] { ['A','B','C','E'],['S','F','C','S'],['A','D','E','E']}, "SEE",true
            ],
            [
                new char[][]{ ['A','B','C','E'],['S','F','C','S'],['A','D','E','E']}, "ABCB",false
            ],
            [
                new char[][] { ['a', 'a', 'b', 'a', 'a', 'b'], ['b', 'a', 'b', 'a', 'b', 'b'], ['b', 'a', 'b', 'b', 'b', 'b'], ['a', 'a', 'b', 'a', 'b', 'a'], ['b', 'b', 'a', 'a', 'a', 'b'], ['b', 'b', 'b', 'a', 'b', 'a'] },"aaaababab",true
            ]
        ];

        [Test]
        [TestCaseSource(nameof(_testCase1))]
        public void TestCase(char[][] boardArray, string word, bool expected)
        {
            var solution = new Solution();

            var exist = solution.Exist(boardArray,word);

            Assert.That(exist, Is.EqualTo(expected));
        }
    }
}