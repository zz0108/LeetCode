using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode79Solution
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            var start = word[0];

            var rows = board.Length;

            var cols = board[0].Length;

            var visited = new bool[rows, cols];

            var tempWord = new StringBuilder();

            var isExist = false;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (board[i][j] != start) continue;

                    tempWord.Append(board[i][j]);

                    visited[i,j] = true;

                    Dfs(i, j, word, board, tempWord, isExist, visited);

                    visited[i, j] = false;

                    if (tempWord.Length > 0)
                    {
                        tempWord.Remove(tempWord.Length - 1, 1);
                    }

                    if (isExist) return true;
                }
            }

            return false;
        }

        private void Dfs(int x, int y, string word, char[][] board, StringBuilder tempWord, bool isExist,
            bool[,] visited)
        {

            if (tempWord.ToString() == word)
            {
                isExist = true;
                return;
            }

            var rows = board.Length;

            var cols = board[0].Length;

            int[] dx = [0, 1, 0, -1];
            int[] dy = [1, 0, -1, 0];

            for (var i = 0; i < 4; i++)
            {
                var newX = dx[i] + x;
                var newY = dy[i] + y;

                if(!IsValid(newX,newY,rows,cols) || visited[newX,newY]) continue;

                tempWord.Append(board[newX][newY]);

                visited[newX,newY] = true;

                Dfs(newX, newY, word, board, tempWord, isExist, visited);

                if (tempWord.Length > 0)
                {
                    tempWord.Remove(tempWord.Length - 1, 1);
                }

                visited[newX, newY] = false;

                if (isExist) return;
            }
        }

        private bool IsValid(int x, int y,int rows,int cols)
        {
            return x >= 0 && y >= 0 && x < rows && y < cols;
        }
    }
}
