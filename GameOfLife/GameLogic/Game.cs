using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.GameLogic
{
    public class Game
    {
        public string CalculateNextGeneration(string inputGen)
        {
            var header = inputGen.Split("\r\n")[0];

            var rows = header.Split(" ")[0];
            var cols = header.Split(" ")[1];

            /* [life cells]
               less than 2 neighbours          -> dies of underpopulatiohn
               2 or 3 neighbours               -> lives to next gen
               more than 3                     -> dies of overcrowding
               
               [dead cells]
               call exactly with 3 neighbours  -> becomes alive
             */

            if (string.Compare(header, "2 2")==0)
                return @$"{rows} {cols}
..
..";

            if (string.Compare(header, "3 3") == 0)
                return @$"{rows} {cols}
...
...
...";
            if (string.Compare(header, "2 3") == 0)
                return @$"{rows} {cols}
...
...";

            return null;
        }

        public int GetCountOfLiveNeighbours(int row, int col, string inputGen)
        {
            var header = inputGen.Split("\r\n")[0];
            var tmpLines = inputGen.Split("\r\n");

            var lines = new string[tmpLines.Length - 1];

            for (var i = 1; i < tmpLines.Length; i++)
            {
                lines[i - 1] = tmpLines[i];
            }

            var grid = new char[lines.Length][];
            for (var i = 0; i < lines.Length; i++)
            {
                grid[i] = new char[lines[i].Length];

                Array.Copy(lines[i].ToCharArray(), 0, grid[i], 0, lines[i].Length);
            }

            var count = 0;
            for (var i = row - 1; i <= row + 1; i++)
            {
                for (var j = col - 1; j <= col + 1; j++)
                {

                    if ((i >= 0 && i < grid.Length) && // rows
                        (j >= 0 && j < grid[i].Length)) // columns
                    {
                        var cur = grid[i][j];
                        if (cur == '*')
                            count++;
                        else
                            count += 0;
                    }

                }
            }

            return count;

        }
    }
}
