namespace _567._Permutation_in_String;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int[] letters = new int[26];
        foreach (char c in s1)
            letters[c - 97]++;
        int[] buff = new int[26];
        Array.Copy(letters, buff, letters.Length);
        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            if (letters[s2[i] - 97] != 0)
            {
                Array.Copy(letters, buff, letters.Length);
                for (int j = i; j < i + s1.Length; j++)
                {
                    char ch = s2[j];
                    buff[ch - 97]--;
                    if (buff[ch - 97] < 0)
                        break;
                }
                bool win = true;
                for (int bIndex = 0; bIndex < buff.Length; bIndex++)
                {
                    if (buff[bIndex] != 0)
                    {
                        win = false;
                        break;
                    }
                }
                if (win)
                    return true;
            }
        }
        return false;
    }
}