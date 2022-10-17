namespace _1._Two_Sum;

public class Solution
{
    public int[]? TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] halfIndexes = new int[] { -1, -1 };
        int curHalfIndex = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]) == false)
                dict.Add(nums[i], i);
            if (nums[i] == target / 2)
            {
                halfIndexes[curHalfIndex++] = i;
                if (target % 2 == 0 && curHalfIndex == 2)
                    return halfIndexes;
            }
        }

        foreach (var kp in dict)
        {
            int need = target - kp.Key;
            if (dict.ContainsKey(need) && (target % 2 == 1 || need != target/2))
                return new int[] { kp.Value, dict[need] };
        }
        return null;
    }
}
