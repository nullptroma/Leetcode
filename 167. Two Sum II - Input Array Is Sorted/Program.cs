namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -2,-3,4 };
            var res = new Solution().TwoSum(arr, -5);
            Console.WriteLine(String.Join(" ", res));
        }
    }
}