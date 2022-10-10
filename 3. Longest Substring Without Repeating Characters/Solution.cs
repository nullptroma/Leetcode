namespace _3._Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(dict.ContainsKey(c))
            {
                max = Math.Max(max, dict.Count);
                i = dict[c];
                dict.Clear();
            }
            else
                dict.Add(c, i);
        }
        max = Math.Max(max, dict.Count);
        return max;
    }
}
