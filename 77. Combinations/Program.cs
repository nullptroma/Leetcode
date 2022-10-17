namespace _77._Combinations;

internal class Program
{
    static void Main(string[] args)
    {
        var res = new Solution().Combine(4, 2);
        foreach(var row in res)
            Console.WriteLine(string.Join(" ", row));
    }
}
