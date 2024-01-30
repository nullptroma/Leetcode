using System.Text;

namespace _14._Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];
        StringBuilder sb = new StringBuilder(256);
        int maxLen = strs.Select(s => s.Length).Min();
        for (int i = 0; i < maxLen; i++)
        {
            char letter;
            if ((letter = strs[0][i]) != strs[1][i])
                break;
            for (int j = 2; j < strs.Length; j++)
            {
                if (letter != strs[j][i])
                {
                    maxLen = -1;
                    break;
                }
            }
            if(maxLen != -1)
                sb.Append(letter);
        }

        return sb.ToString();
    }
}