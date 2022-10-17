using System.Numerics;

namespace _62._Unique_Paths;

public class Solution
{
    public int UniquePaths(int min, int max)
    {
        min--;
        max--;
        if (min == 0 || max == 0)
            return 1;
        if(min > max)
        {
            min = min + max;
            max = min - max;
            min = min - max; 
        }
        return (int)(Fact(max + 1, min + max) / Fact(1, min));
    }

    private BigInteger Fact(int start, int end)
    {
        BigInteger res = start;
        while (++start <= end)
            res *= start;
        return res;
    }
}
