namespace _542._01_Matrix;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] mat = new int[][] { new int[] { 0,0,0, },
                                    new int[] { 0,1,0, },
                                    new int[] { 1,1,1, },
        };
        var res = new Solution().UpdateMatrix(mat);
        foreach(var row in res)
            Console.WriteLine(String.Join(" ", row));
    }
}
