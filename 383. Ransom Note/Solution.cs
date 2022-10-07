namespace _383._Ransom_Note;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;
        Dictionary<char, int> note = CountChars(ransomNote);
        Dictionary<char, int> mag = CountChars(magazine);
        foreach (var kp in note)
        {
            if (mag.ContainsKey(kp.Key))
            {
                if (mag[kp.Key] < kp.Value)
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
