namespace _240._Search_a_2D_Matrix_II;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            int column = SearchInsert((i) => matrix[row][i], matrix[row].Length, target);
            if (column < matrix[row].Length && matrix[row][column] == target)
                return true;
        }
        return false;
    }

    private int SearchInsert(Func<int, int> getByIndex, int len, int target)
    {
        int l = -1;
        int r = len;
        while (l != r - 1)
        {
            int i = (r + l) / 2;
            if (getByIndex(i) >= target)
                r = i;
            else
                l = i;
        }
        return l + 1;
    }
}