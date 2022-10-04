namespace _350._Intersection_of_Two_Arrays_II;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> table = new Dictionary<int, int>();
        foreach (int n in nums1)
        {
            if (table.ContainsKey(n))
                table[n]++;
            else
                table.Add(n, 1);
        }

        foreach (int n in nums2)
        {
            if (table.ContainsKey(n) && table[n] > 0)
            {
                result.Add(n);
                table[n]--;
            }
        }
        return result.ToArray();
    }
}
