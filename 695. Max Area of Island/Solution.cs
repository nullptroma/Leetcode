namespace _695._Max_Area_of_Island;

public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < visited.Length; i++)
            visited[i] = new bool[grid[i].Length];

        int max = 0;
        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                if (grid[y][x] == 0)
                    continue;

                int curCount = 0;
                Recursion(grid, y, x, ref curCount, visited);
                max = Math.Max(max, curCount);
            }
        }
        return max;
    }

    private void Recursion(int[][] grid, int y, int x, ref int count, bool[][] visited)
    {
        if (visited[y][x] || grid[y][x] == 0)
            return;
        visited[y][x] = true;
        count++;
        for (int i = 1; i < 8; i += 2)
        {
            int nextY = i / 3 + y - 1;
            int nextX = i % 3 + x - 1;
            if (nextY >= 0 && nextY < grid.Length && nextX >= 0 && nextX < grid[nextY].Length)
                Recursion(grid, nextY, nextX, ref count, visited);
        }
    }
}
