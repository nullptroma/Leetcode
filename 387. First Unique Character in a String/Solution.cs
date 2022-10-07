namespace _387._First_Unique_Character_in_a_String;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach (char ch in s)
        {
            if (dic.ContainsKey(ch))
                dic[ch]++;
            else
                dic.Add(ch, 1);
        }
        for (int i = 0; i < s.Length; i++)
            if (dic[s[i]] == 1)
                return i;
        return -1;
    }
}
