namespace _167._Two_Sum_II___Input_Array_Is_Sorted;

public class Solution
{
    public int[]? TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int cur = numbers[i];
            int nextTar = target - cur;
            int index = Search(numbers, nextTar);
            if (i == index || index < 0 || index >= numbers.Length)
                continue;
            int val = numbers[index];
            if (cur + val == target)
            {
                if (i > index)
                {
                    i = i + index;
                    index = i - index;
                    i = i - index;
                }
                return new int[] { i + 1, index + 1 };
            }
        }
        return null;
    }

    public int Search(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l < r - 1)
        {
            int i = l + (r - l) / 2;
            int cur = nums[i];
            if (cur == target)
                return i;
            if (cur > target)
                r = i;
            else
                l = i;
        }
        return -1;
    }
}