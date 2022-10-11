namespace _70._Climbing_Stairs;

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 0)
            return 0;
        int cur0 = 0;
        int cur1 = 1;
        while (--n > 0)
        {
            int buf = cur0 + cur1;
            cur0 = cur1;
            cur1 = buf;
        }
        return cur0 + cur1;
    }
}