namespace _242._Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> d1 = CountChars(s);
        Dictionary<char, int> d2 = CountChars(t);
        if (d1.Count != d2.Count)
            return false;
        foreach (var kp in d1)
        {
            if (d2.ContainsKey(kp.Key))
            {
                if (d2[kp.Key] != kp.Value)
                    return false;
            }
            else
                return false;
        }
        return true;
    }

    private Dictionary<char, int> CountChars(string str)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char ch in str)
        {
            if (dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict.Add(ch, 1);
        }
        return dict;
    }
}
