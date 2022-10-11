namespace _733._Flood_Fill;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[][] {  new int[] { 1,1,1 },
                                        new int[] { 1,1,0 },
                                        new int[] { 1,0,1 } };
        var res = new Solution().FloodFill(matrix, 1, 1, 2);
        foreach (var row in res)
            Console.WriteLine(String.Join(" ", row));
    }
}
