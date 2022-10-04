namespace _53._Maximum_Subarray;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int best_sum = int.MinValue;
        int current_sum = 0;
        foreach(var x in nums)
        {
            current_sum = Math.Max(x, current_sum + x);
            best_sum = Math.Max(best_sum, current_sum);
        }
        return best_sum;
    }
}