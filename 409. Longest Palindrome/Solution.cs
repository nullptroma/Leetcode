namespace _409._Longest_Palindrome;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(var ch in s)
        {
            if(dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict.Add(ch, 1);
        }
        int sum = 0;
        bool hasOdd = false;
        foreach(var v in dict.Values)
        {
            sum += v / 2;
            if(v % 2 == 1)
                hasOdd = true;
        }
        return sum*2 + (hasOdd ? 1 : 0);
    }
}
