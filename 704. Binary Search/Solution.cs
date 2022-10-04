namespace _704._Binary_Search;

public class Solution
{
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
