namespace _74._Search_a_2D_Matrix;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = SearchInsert((i) => matrix[i][0], matrix.Length, target);
        if (row < matrix.Length && matrix[row][0] == target)
            return true;
        if (row > 0)
            row--;
        int column = SearchInsert((i) => matrix[row][i], matrix[row].Length, target);
        return column < matrix[row].Length && matrix[row][column] == target;
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
