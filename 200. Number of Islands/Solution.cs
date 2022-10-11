namespace _200._Number_of_Islands;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int[][] was = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
            was[i] = new int[grid[i].Length];

        int curId = 0;
        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                if (was[y][x] == 0 && grid[y][x] == '1')
                    curId++;
                else
                    continue;

                Recursion(grid, was, y, x, curId);
            }
        }
        return curId;
    }

    private void Recursion(char[][] grid, int[][] was, int y, int x, int id)
    {
        if (was[y][x] != 0 || grid[y][x] != '1')
            return;
        was[y][x] = id;
        for (int i = 1; i < 8; i += 2)
        {
            int nextY = i / 3 + y - 1;
            int nextX = i % 3 + x - 1;
            if (nextY >= 0 && nextY < was.Length && nextX >= 0 && nextX < was[nextY].Length)
                Recursion(grid, was, nextY, nextX, id);
        }
    }
}
