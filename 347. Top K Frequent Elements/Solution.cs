namespace _347._Top_K_Frequent_Elements;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var num in nums)
            if (!dictionary.TryAdd(num, 1))
                dictionary[num]++;
        return dictionary.OrderByDescending(kp=>kp.Value).Take(k).Select(kp=>kp.Key).ToArray();
    }
}