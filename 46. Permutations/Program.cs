namespace _46._Permutations;

internal class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1,2,3 };
        var l = new Solution().Permute(arr);
        foreach (var row in l)
            Console.WriteLine(String.Join(" ", row));
    }
}
