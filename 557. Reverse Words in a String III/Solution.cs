using System.Text;

namespace _557._Reverse_Words_in_a_String_III;

public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                sb.Append(' ');
            else
            {
                int startIndex = i;
                while (i < s.Length - 1 && s[i + 1] != ' ')
                    i++;
                for (int r = i; r >= startIndex; r--)
                    sb.Append(s[r]);
            }
        }
        return sb.ToString();
    }
}
