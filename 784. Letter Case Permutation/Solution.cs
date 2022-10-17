using System.Text;

namespace _784._Letter_Case_Permutation;

public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        HashSet<string> set = new HashSet<string>();
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < Math.Pow(2, s.Length); i++)
        {
            UppercasePerMask(sb, i);
            set.Add(sb.ToString());
        }
        return set.ToList();
    }

    private void UppercasePerMask(StringBuilder sb, int mask)
    {
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(sb[i]))
                sb[i] = mask % 2 == 1 ? char.ToUpper(sb[i]) : char.ToLower(sb[i]);
            mask >>= 1;
        }
    }
}