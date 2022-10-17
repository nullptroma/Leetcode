namespace _438._Find_All_Anagrams_in_a_String;

public class Solution
{
    public IList<int> FindAnagrams(string s, string target)
    {
        List<int> result = new List<int>();
        int[] array = new int[26];
        int[] buf = new int[26];
        foreach(var ch in target)
            array[ch-97]+=1;
        for(int i = 0; i <= s.Length-target.Length; i++)
        {
            int chIndex = s[i]-97;
            if (array[chIndex] != 0)
            {
                Array.Copy(array, buf, array.Length);
                bool win = true;
                for (int j = i; j < i + target.Length; j++)
                {
                    int chIndex2 = s[j] - 97;
                    buf[chIndex2] -= 1;
                    if (buf[chIndex2] < 0)
                    {
                        win = false;
                        break;
                    }
                }
                if (win)
                    result.Add(i);
            }
        }
        return result;
    }
}
