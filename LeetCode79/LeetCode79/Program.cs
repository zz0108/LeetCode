using LeetCode79Solution;

namespace LeetCode79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test case 1.

            var board = new char[][] { ['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E'] };

            var word = "ABCCED";

            var solution = new Solution();

            solution.Exist(board, word);

            // test case 2.

            //var board = new[,] { { "A", "B", "C", "E" }, { "S", "F", "C", "S" }, { "A", "D", "E", "E" } };

            //var word = "ABCCED";

            // test case 3.

            //var board = new[,] { { "A", "B", "C", "E" }, { "S", "F", "C", "S" }, { "A", "D", "E", "E" } };

            //var word = "ABCCED";

        }
    }
}
