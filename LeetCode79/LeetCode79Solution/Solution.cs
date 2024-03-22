using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dumpify;

namespace LeetCode79Solution
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            var start = word[0];

            var visited = new bool[board.Length, board[0].Length];

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] != start) continue;


                    visited[i,j] = true;

                    if (board[i][j] == word[0] && Dfs(i, j, word, board, 0,visited))
                    {
                        return true;
                    }

                    visited[i, j] = false;

                }
            }

            return false;
        }

        private bool Dfs(int x, int y, string word, char[][] board,int k,
            bool[,] visited)
        {
            if (board[x][y] == word[k])
            {
                if (k == word.Length - 1)
                {
                    return true;
                }

                visited[x, y] = true;

                int[] dx = [0, 1, 0, -1];
                int[] dy = [1, 0, -1, 0];

                for (var i = 0; i < 4; i++)
                {
                    var newX = dx[i] + x;
                    var newY = dy[i] + y;

                    if (IsValid(newX, newY, board) && !visited[newX, newY] && Dfs(newX, newY, word, board, k + 1, visited))
                        return true;
                }

                visited[x, y] = false;
            }

            return false;
        }

        private bool IsValid(int x, int y, char[][] board)
        {
            return x > -1 && x < board.Length && y > -1 && y < board[0].Length;
        }
    }
}
