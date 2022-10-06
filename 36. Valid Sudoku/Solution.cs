namespace _36._Valid_Sudoku;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        return CheckRows(board) && CheckColumns(board) && CheckSubBoxes(board);
    }

    private bool CheckRows(char[][] board)
    {
        foreach (char[] row in board)
        {
            HashSet<char> rowSet = new HashSet<char>();
            foreach (char ch in row)
            {
                if (ch != '.')
                {
                    if (rowSet.Contains(ch))
                        return false;
                    rowSet.Add(ch);
                }
            }
        }
        return true;
    }

    private bool CheckColumns(char[][] board)
    {
        for (int columnIndex = 0; columnIndex < board[0].Length; columnIndex++)
        {
            HashSet<char> columnSet = new HashSet<char>();
            for (int rowIndex = 0; rowIndex < board[columnIndex].Length; rowIndex++)
            {
                char ch = board[rowIndex][columnIndex];
                if (ch != '.')
                {
                    if (columnSet.Contains(ch))
                        return false;
                    columnSet.Add(ch);
                }
            }
        }
        return true;
    }

    private bool CheckSubBoxes(char[][] board)
    {
        for (int i = 0; i < 27; i += 3)
        {
            int y = i / 9 * 3;
            int x = i % 9;
            if (CheckSubBox(board, y, x) == false)
                return false;
        }
        return true;
    }

    private bool CheckSubBox(char[][] board, int startY, int startX)
    {
        HashSet<char> set = new HashSet<char>();
        for (int y = startY; y < startY + 3; y++)
        {
            for (int x = startX; x < startX + 3; x++)
            {
                char ch = board[y][x];
                if (ch != '.')
                {
                    if (set.Contains(ch))
                        return false;
                    set.Add(ch);
                }
            }
        }
        return true;
    }
}
