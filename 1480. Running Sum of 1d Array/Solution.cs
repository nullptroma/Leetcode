namespace _1480._Running_Sum_of_1d_Array;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            result[i] = nums[i] + result[i - 1];
        return result;
    }
}
