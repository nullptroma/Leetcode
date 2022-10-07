namespace _566._Reshape_the_Matrix;

internal class Program
{
    static void Main(string[] args)
    {
        var res = new Solution().MatrixReshape(new int[][] { new int[] { 1, 2 }, new int[] { 4, 5 } }, 2, 4);
        foreach (var row in res)
            Console.WriteLine(String.Join(" ", row));
    }
}