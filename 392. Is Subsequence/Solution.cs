namespace _392._Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;
        int sIndex = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[sIndex])
            {
                sIndex++;
                if (sIndex >= s.Length)
                    return true;
            }
        }
        return false;
    }
}