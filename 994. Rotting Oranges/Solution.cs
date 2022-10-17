namespace _994._Rotting_Oranges;

public class Solution
{
    public int OrangesRotting(int[][] mat)
    {
        int w = mat[0].Length;
        int h = mat.Length;

        Work(mat, i =>
        {
            int y = h - i / w - 1;
            int x = i % w;
            return (y, x);
        });
        Work(mat, i =>
        {
            int y = i / w;
            int x = w - i % w - 1;
            return (y, x);
        });
        Work(mat, i =>
        {
            int y = i / w;
            int x = i % w;
            return (y, x);
        });
        int max = Work(mat, i =>
        {
            int y = h - i / w - 1;
            int x = w - i % w - 1;
            return (y, x);
        });
        return max;
    }

    private int Work(int[][] mat, Func<int, (int y, int x)> getXY)
    {
        int absMax = 0;
        for (int i = 0; i < mat.Length * mat[0].Length; i++)
        {
            var dot = getXY(i);
            int x = dot.x;
            int y = dot.y;
            if (mat[y][x] == 0)
                continue;
            int max = int.MinValue;
            for (int shift = 1; shift < 9; shift += 2)
            {
                int newY = shift / 3 + y - 1;
                int newX = shift % 3 + x - 1;
                if (newY >= 0 && newY < mat.Length && newX >= 0 && newX < mat[newY].Length)
                    max = Math.Max(max, mat[newY][newX]);
            }
            mat[y][x] = max + 1;
            absMax = Math.Max(absMax, mat[y][x]);
        }
        return absMax;
    }
}