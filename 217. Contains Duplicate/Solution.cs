namespace _217._Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return nums.ToHashSet().Count != nums.Length;
    }
}
