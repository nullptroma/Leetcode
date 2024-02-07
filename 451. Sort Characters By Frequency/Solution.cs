namespace _451._Sort_Characters_By_Frequency;

public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char, int> dictionary = [];
        foreach (var c in s.Where(c => !dictionary.TryAdd(c, 1)))
            dictionary[c]++;

        var list = dictionary.ToList();
        return String.Join("",
            list.OrderByDescending(element => element.Value)
                .Select(element => new string(element.Key, element.Value)));
    }
}