namespace _733._Flood_Fill;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int[][] res = new int[image.Length][];
        for (int i = 0; i < res.Length; i++)
            res[i] = image[i].ToArray();

        bool[][] colored = new bool[image.Length][];
        for (int i = 0; i < colored.Length; i++)
            colored[i] = new bool[image[i].Length];
        Recursion(res, sr, sc, res[sr][sc], color, colored);
        return res;
    }

    private void Recursion(int[][] image, int y, int x, int sourceColor, int toColor, bool[][] colored)
    {
        if (image[y][x] != sourceColor || colored[y][x])
            return;
        image[y][x] = toColor;
        colored[y][x] = true;
        for (int i = 1; i < 8; i += 2)
        {
            int nextY = i / 3 + y - 1;
            int nextX = i % 3 + x - 1;
            if (nextY >= 0 && nextY < image.Length && nextX >= 0 && nextX < image[nextY].Length)
                Recursion(image, nextY, nextX, sourceColor, toColor, colored);
        }
    }
}
