namespace _36._Valid_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[][] {    new char[]{'.', '.', '4', '.', '.', '.', '6', '3', '.'},
                                        new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                                        new char[]{'5', '.', '.', '.', '.', '.', '.', '9', '.'},
                                        new char[]{'.', '.', '.', '5', '6', '.', '.', '.', '.'},
                                        new char[]{'4', '.', '3', '.', '.', '.', '.', '.', '1'},
                                        new char[]{'.', '.', '.', '7', '.', '.', '.', '.', '.'},
                                        new char[]{'.', '.', '.', '5', '.', '.', '.', '.', '.'},
                                        new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                                        new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'}};
            Console.WriteLine(new Solution().IsValidSudoku(arr));
        }
    }
}