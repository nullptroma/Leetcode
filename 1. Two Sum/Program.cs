namespace _1._Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(String.Join(" ", new Solution().TwoSum(new int[] {3,2,4}, 6)??new int[0]));
    }
}