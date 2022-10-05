namespace _566._Reshape_the_Matrix;

public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int[][] result = new int[r][];
        for (int i = 0; i < result.Length; i++)
            result[i] = new int[c];

        int height = mat.Length;
        int width = mat[0].Length;
        int size = r * c;
        if (size != height * width)
            return mat;
        for(int i = 0; i < size; i++)
        {
            int ySource = i / width;
            int xSource = i % width;

            int yTo = i / c;
            int xTo = i % c;
            result[yTo][xTo] = mat[ySource][xSource];
        }
        return result;
    }
}