namespace _542._01_Matrix;

public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        bool hasChanges = true;
        while(hasChanges)
        {
            hasChanges = false;
            for (int y = 0; y < mat.Length; y++)
            {
                for (int x = 0; x < mat[y].Length; x++)
                {
                    if (mat[y][x] == 0)
                        continue;
                    int min = int.MaxValue;
                    for (int i = 1; i < 9; i += 2)
                    {
                        int newY = i / 3 + y - 1;
                        int newX = i % 3 + x - 1;
                        if (newY >= 0 && newY < mat.Length && newX >= 0 && newX < mat[newY].Length)
                        {
                            min = Math.Min(min, mat[newY][newX]);
                        }
                    }
                    if(mat[y][x] != min + 1)
                        hasChanges = true;
                    mat[y][x] = min + 1;
                }
            }
        }
        return mat;
    }
}