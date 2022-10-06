namespace _283._Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for(int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] != 0)
                continue;
            int nonZeroIndex = i + 1;
            while (nonZeroIndex < nums.Length && nums[nonZeroIndex] == 0)
                nonZeroIndex++;
            if (nonZeroIndex >= nums.Length)
                break;
            nums[i] = nums[nonZeroIndex];
            nums[nonZeroIndex] = 0;
        }
    }
}
