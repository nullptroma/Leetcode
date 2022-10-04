namespace _278._First_Bad_Version;

public class VersionControl
{
    protected int _badVersion = 0;
    protected bool IsBadVersion(int version) => version >= _badVersion;
}

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        long l = -1;
        long r = n;
        while (l != r - 1)
        {
            long i = (r + l) / 2;
            bool res = IsBadVersion((int)i);
            if (res)
                r = i;
            else
                l = i;
        }
        return (int)l + 1;
    }

    public int FirstBadVersion(int n, int bad)
    {
        _badVersion = bad;
        return FirstBadVersion(n);
    }
}

