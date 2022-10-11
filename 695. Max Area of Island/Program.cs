namespace _695._Max_Area_of_Island;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = { new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 }, new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 } };
        Console.WriteLine(new Solution().MaxAreaOfIsland(matrix));
    }
}
