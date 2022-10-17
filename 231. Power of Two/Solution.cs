namespace _231._Power_of_Two;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        double log = Math.Log(n, 2);
        return Math.Round(log, 12) == (int)log;
    }
}
