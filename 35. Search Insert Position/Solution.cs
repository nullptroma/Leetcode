namespace _35._Search_Insert_Position;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l != r - 1)
        {
            int i = (r + l) / 2;
            if (nums[i] >= target)
                r = i;
            else
                l = i;
        }
        return l + 1;
    }
}