using System.Text;

namespace _451._Sort_Characters_By_Frequency.Fast;

public class Solution
{
    private static int Comparer((char, int) el1, (char, int) el2)
    {
        return el2.Item2.CompareTo(el1.Item2);
    }
    
    public string FrequencySort(string s)
    {
        var count = new (char, int)[128];
        for (var ch = (char)0; ch < count.Length; ch++)
            count[ch].Item1 = ch;
        foreach (var c in s)
            count[c].Item2++;
        var sb = new StringBuilder();
        Array.Sort(count, Comparer);
        for (var ch = (char)0; ch < count.Length; ch++)
            while (count[ch].Item2-- > 0)
                sb.Append(count[ch].Item1);
        return sb.ToString();
    }
}