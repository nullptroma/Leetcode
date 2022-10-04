namespace _205._Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> table = new Dictionary<char, char>();
        Dictionary<char, char> antiTable = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            char source = s[i];
            char to = t[i];
            if (table.ContainsKey(source))
            {
                if (table[source] != to)
                    return false;
            }
            else
                table.Add(source, to);

            if (antiTable.ContainsKey(to))
            {
                if (antiTable[to] != source)
                    return false;
            }
            else
                antiTable.Add(to, source);
        }
        return true;
    }
}
