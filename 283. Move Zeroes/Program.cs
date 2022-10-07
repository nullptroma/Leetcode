namespace _283._Move_Zeroes;

internal class Program
{
    static void Main(string[] args)
    {
        var test = new int[] { 0, 1, 0, 3, 12 };
        new Solution().MoveZeroes(test);
        Console.WriteLine(String.Join(" ", test));
    }
}