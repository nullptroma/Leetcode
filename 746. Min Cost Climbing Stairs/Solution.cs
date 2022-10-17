namespace _746._Min_Cost_Climbing_Stairs;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int prev = cost[0];
        int cur = cost[1];
        for(int i = 2; i < cost.Length; i++)
        {
            int next = cost[i] + Math.Min(prev, cur);
            prev = cur;
            cur = next;
        }
        return Math.Min(prev, cur);
    }
}
